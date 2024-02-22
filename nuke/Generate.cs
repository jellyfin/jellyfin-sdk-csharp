using System.IO;
using Nuke.Common;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tools.DotNet;
using Serilog;

public class Generate : NukeBuild
{
    public static int Main () => Execute<Generate>(x => x.Run);

    [Parameter("Configuration to build - 'Stable' (default) or 'Unstable'")]
    readonly Configuration Configuration = Configuration.Stable;
    
    [Solution(GenerateProjects = true)]
    readonly Solution Solution;

    Target RestoreTools => g => g.Executes(() => DotNetTasks.DotNetToolRestore());
    
    Target CopyConfig => g => g
        .DependsOn(RestoreTools)
        .Executes(() =>
        {
            var sourceFile = Configuration == Configuration.Stable
                ? "kiota-lock-stable.json"
                : "kiota-lock-unstable.json";
            var sourcePath = Path.Combine(Solution.Jellyfin_Sdk.Directory, "Generated", sourceFile);
            var destinationPath = Path.Combine(Solution.Jellyfin_Sdk.Directory, "Generated", "kiota-lock.json");
            
            Log.Debug("Copying {0} to {1}", sourcePath, destinationPath);
            File.Copy(sourcePath, destinationPath, overwrite: true);
        });

    Target Run => g => g
        .DependsOn(CopyConfig)
        .Executes(() =>
        {
            DotNetTasks.DotNet(
                arguments: "kiota update --output Generated",
                workingDirectory: Solution.Jellyfin_Sdk.Directory);
            
            // TODO remove when Kiota 1.1.2 is released.
            var outputPath = Path.Combine(Solution.Jellyfin_Sdk.Directory, "Generated");
            foreach (var file in Directory.EnumerateFiles(outputPath, "*.cs", SearchOption.AllDirectories))
            {
                var contents = File.ReadAllText(file);
                contents = contents
                    .Replace(
                        "application/json;profile=\"CamelCase\"",
                        "application/json;profile=\\\"CamelCase\\\"")
                    .Replace(
                        "application/json;profile=\"PascalCase\"",
                        "application/json;profile=\\\"PascalCase\\\"");

                File.WriteAllText(file, contents);
            }
        });
}
