using BenchmarkDotNet.Attributes;
using Jellyfin.Sdk.Internal;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Serialization.Json;

namespace Jellyfin.Sdk.Benchmarks;

/// <summary>
/// Compares Kiota's parse node with the SDK's on captured responses.
/// </summary>
[MemoryDiagnoser]
public class DeserializationBenchmarks
{
    private readonly JsonParseNodeFactory _kiota = new(JellyfinRequestAdapter.SerializationContext);
    private readonly JellyfinJsonParseNodeFactory _jellyfin = new(JellyfinRequestAdapter.SerializationContext);
    private byte[] _content = [];

    [ParamsSource(nameof(Files))]
    public string File { get; set; } = string.Empty;

    public static IEnumerable<string> Files => Fixture.Files.Where(f => !f.Contains("edge-cases", StringComparison.Ordinal));

    [GlobalSetup]
    public void Setup() => _content = System.IO.File.ReadAllBytes(File);

    [Benchmark(Baseline = true)]
    public Task<IParsable> Kiota() => Fixture.ParseAsync(_kiota, File, _content);

    [Benchmark]
    public Task<IParsable> Jellyfin() => Fixture.ParseAsync(_jellyfin, File, _content);
}
