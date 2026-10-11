using BenchmarkDotNet.Running;
using Jellyfin.Sdk;
using Jellyfin.Sdk.Benchmarks;
using Jellyfin.Sdk.Internal;
using Microsoft.Kiota.Serialization.Json;

// verify: parse every fixture with Kiota's node and the SDK's node, and compare the models.
if (args is ["verify"])
{
    var kiota = new JsonParseNodeFactory(JellyfinRequestAdapter.SerializationContext);
    var jellyfin = new JellyfinJsonParseNodeFactory(JellyfinRequestAdapter.SerializationContext);
    var failures = 0;
    foreach (var file in Fixture.Files)
    {
        var content = await File.ReadAllBytesAsync(file);
        var expected = Fixture.Serialize(await Fixture.ParseAsync(kiota, file, content));
        var actual = Fixture.Serialize(await Fixture.ParseAsync(jellyfin, file, content));
        var ok = string.Equals(expected, actual, StringComparison.Ordinal);
        failures += ok ? 0 : 1;
        Console.WriteLine($"{(ok ? "same" : "DIFF")}  {Path.GetFileName(file)}");
        if (!ok)
        {
            var index = expected.Zip(actual).TakeWhile(p => p.First == p.Second).Count();
            Console.WriteLine($"      kiota: ...{expected.Substring(Math.Max(0, index - 80), Math.Min(160, expected.Length - Math.Max(0, index - 80)))}");
            Console.WriteLine($"      sdk:   ...{actual.Substring(Math.Max(0, index - 80), Math.Min(160, actual.Length - Math.Max(0, index - 80)))}");
        }
    }

    return failures == 0 ? 0 : 1;
}

BenchmarkSwitcher.FromAssembly(typeof(DeserializationBenchmarks).Assembly).Run(args);
return 0;
