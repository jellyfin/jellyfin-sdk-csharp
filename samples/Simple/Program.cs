using System.Net;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using Jellyfin.Sdk;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;

namespace Simple;

internal static class Program
{
    private static async Task Main()
    {
        var serviceProvider = ConfigureServices();

        // Initialize the sdk client settings. This only needs to happen once on startup.
        var sdkClientSettings = serviceProvider.GetRequiredService<JellyfinSdkSettings>();
        sdkClientSettings.Initialize(
            "My-Jellyfin-Client",
            "0.0.1",
            "Sample Device",
            $"this-is-my-device-id-{Guid.NewGuid():N}");

       using var sampleService = serviceProvider.GetRequiredService<SimpleService>();
        await sampleService.RunAsync()
            .ConfigureAwait(false);

        Console.WriteLine("Simple sample complete");
    }

    private static ServiceProvider ConfigureServices()
    {
        var serviceCollection = new ServiceCollection();

        // Add Http Client
        serviceCollection.AddHttpClient("Default", c =>
            {
                c.DefaultRequestHeaders.UserAgent.Add(
                    new ProductInfoHeaderValue(
                        "My-Jellyfin-Client",
                        "0.0.1"));

                c.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue(MediaTypeNames.Application.Json, 1.0));
                c.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("*/*", 0.8));
            })
            .ConfigurePrimaryHttpMessageHandler(_ => new SocketsHttpHandler
            {
                AutomaticDecompression = DecompressionMethods.All,
                RequestHeaderEncodingSelector = (_, _) => Encoding.UTF8
            });

        // Add Jellyfin SDK services.
        serviceCollection.AddSingleton<JellyfinSdkSettings>();
        serviceCollection.AddSingleton<IAuthenticationProvider, JellyfinAuthenticationProvider>();
        serviceCollection.AddScoped<IRequestAdapter, JellyfinRequestAdapter>(s => new JellyfinRequestAdapter(
            s.GetRequiredService<IAuthenticationProvider>(),
            s.GetRequiredService<JellyfinSdkSettings>(),
            s.GetRequiredService<IHttpClientFactory>().CreateClient("Default")));
        serviceCollection.AddScoped<JellyfinApiClient>();

        // Add sample service
        serviceCollection.AddSingleton<SimpleService>();

        return serviceCollection.BuildServiceProvider();
    }
}
