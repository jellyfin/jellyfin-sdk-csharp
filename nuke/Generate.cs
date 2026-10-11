using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tools.DotNet;

public partial class Generate : NukeBuild
{
    const string StableOpenApi = "https://api.jellyfin.org/openapi/jellyfin-openapi-stable.json";

    const string UnstableOpenApi = "https://api.jellyfin.org/openapi/jellyfin-openapi-unstable.json";

    static readonly string[] _ignoreFiles =
    [
        ".editorconfig",
        "kiota-lock.json"
    ];

    public static int Main () => Execute<Generate>(x => x.Run);

    [Parameter("Configuration to build - 'Stable' (default) or 'Unstable'")]
    readonly Configuration Configuration = Configuration.Stable;

    [Solution(GenerateProjects = true)]
    readonly Solution Solution;

    string OpenApiUrl => Configuration == Configuration.Stable
        ? StableOpenApi
        : UnstableOpenApi;

    AbsolutePath GeneratedDirectory => Solution.Jellyfin_Sdk.Directory / "Generated";

    AbsolutePath KiotaLockPath => GeneratedDirectory / "kiota-lock.json";

    AbsolutePath SpecificationPath => TemporaryDirectory / "jellyfin-openapi.json";

    Target RestoreTools => g => g.Executes(() => DotNetTasks.DotNetToolRestore());

    Target CleanGenerated => g => g.Executes(() =>
    {
        var generatedDirectory = new DirectoryInfo(GeneratedDirectory);

        foreach (var file in generatedDirectory.GetFiles())
        {
            if (_ignoreFiles.Contains(file.Name, StringComparer.OrdinalIgnoreCase))
            {
                continue;
            }

            file.Delete();
        }

        foreach (var directory in generatedDirectory.GetDirectories())
        {
            directory.Delete(recursive: true);
        }
    });

    Target DownloadSpecification => g => g.Executes(async () =>
    {
        using var httpClient = new HttpClient();
        var specification = await httpClient.GetStringAsync(OpenApiUrl);

        // Kiota only generates schemas reachable from a path, patch in the WebSocket message schemas.
        File.WriteAllText(SpecificationPath, PatchWebSocketSpecification(specification));
    });

    Target UpdateConfig => g => g
        .DependsOn(RestoreTools, CleanGenerated)
        .Executes(() => SetDescriptionLocation(OpenApiUrl));

    Target GenerateClient => g => g
        .DependsOn(UpdateConfig, DownloadSpecification)
        .Executes(() =>
        {
            // Generate from the local patched copy, but keep the published spec location in the lock file.
            SetDescriptionLocation(SpecificationPath);
            try
            {
                DotNetTasks.DotNet(
                    arguments: "kiota update --output Generated",
                    workingDirectory: Solution.Jellyfin_Sdk.Directory);
            }
            finally
            {
                SetDescriptionLocation(OpenApiUrl);
            }

            RemoveWebSocketRequestBuilder();
            WriteWebSocketMessages();
        });

    Target Run => g => g
        .DependsOn(GenerateClient);

    void SetDescriptionLocation(string location)
    {
        var config = File.ReadAllText(KiotaLockPath);
        config = DescriptionLocationRegex().Replace(config, _ => $"\"descriptionLocation\": {JsonSerializer.Serialize(location)}");
        File.WriteAllText(KiotaLockPath, config);
    }

    [GeneratedRegex("""
                    "descriptionLocation": ".+"
                    """)]
    private static partial Regex DescriptionLocationRegex();
}
