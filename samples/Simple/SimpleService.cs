using Jellyfin.Sdk;
using Jellyfin.Sdk.Generated.Models;

namespace Simple;

/// <summary>
/// Sample Jellyfin service.
/// </summary>
public class SimpleService : IDisposable
{
    private readonly JellyfinSdkSettings _sdkClientSettings;
    private readonly JellyfinApiClient _jellyfinApiClient;

    /// <summary>
    ///
    /// </summary>
    /// <param name="sdkClientSettings"></param>
    /// <param name="jellyfinApiClient"></param>
    public SimpleService(
        JellyfinSdkSettings sdkClientSettings,
        JellyfinApiClient jellyfinApiClient)
    {
        _sdkClientSettings = sdkClientSettings;
        _jellyfinApiClient = jellyfinApiClient;
    }

    /// <summary>
    /// Run the sample.
    /// </summary>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    public async Task RunAsync()
    {
        var validServer = false;
        do
        {
            // Prompt for server url.
            // Url must be proto://host/path
            // ex: https://demo.jellyfin.org/stable
            Console.Write("Server Url: ");
            var host = Console.ReadLine();

            _sdkClientSettings.SetServerUrl(host);

            try
            {
                // Get public system info to verify that the url points to a Jellyfin server.
                var systemInfo = await _jellyfinApiClient.System.Info.Public.GetAsync()
                    .ConfigureAwait(false);
                validServer = true;
                Console.WriteLine($"Connected to {host}");
                Console.WriteLine($"Server Name: {systemInfo.ServerName}");
                Console.WriteLine($"Server Version: {systemInfo.Version}");
            }
            catch (InvalidOperationException ex)
            {
                await Console.Error.WriteLineAsync("Invalid url").ConfigureAwait(false);
                await Console.Error.WriteLineAsync(ex.Message).ConfigureAwait(false);
            }
            catch (SystemException ex)
            {
                await Console.Error.WriteLineAsync($"Error connecting to {host}").ConfigureAwait(false);
                await Console.Error.WriteLineAsync(ex.Message).ConfigureAwait(false);
            }
        }
        while (!validServer);

        var validUser = false;

        UserDto userDto = null!;
        do
        {
            try
            {
                Console.Write("Username: ");
                var username = Console.ReadLine();

                Console.Write("Password: ");
                var password = Console.ReadLine();

                Console.WriteLine($"Logging into {_sdkClientSettings.ServerUrl}");

                // Authenticate user.
                var authenticationResult = await _jellyfinApiClient.Users.AuthenticateByName.PostAsync(new AuthenticateUserByName
                    {
                        Username = username,
                        Pw = password
                    })
                    .ConfigureAwait(false);

                _sdkClientSettings.SetAccessToken(authenticationResult.AccessToken);
                userDto = authenticationResult.User;
                Console.WriteLine("Authentication success.");
                Console.WriteLine($"Welcome to Jellyfin - {userDto.Name}");
                validUser = true;
            }
            catch (Exception ex)
            {
                await Console.Error.WriteLineAsync("Error authenticating.").ConfigureAwait(false);
                await Console.Error.WriteLineAsync(ex.Message).ConfigureAwait(false);
            }
        }
        while (!validUser);

        await PrintViews()
            .ConfigureAwait(false);
    }

    private async Task PrintViews()
    {
        try
        {
            var views = await _jellyfinApiClient.UserViews.GetAsync()
                .ConfigureAwait(false);
            Console.WriteLine("Printing Views:");
            foreach (var view in views.Items)
            {
                var requestInformation = _jellyfinApiClient.Items[view.Id.Value].Images[ImageType.Primary.ToString()]
                    .ToGetRequestInformation();
                var uri = _jellyfinApiClient.BuildUri(requestInformation);
                
                Console.WriteLine($"{view.Id} - {view.Name} - {uri.ToString()}");
            }
        }
        catch (Exception ex)
        {
            await Console.Error.WriteLineAsync("Error getting user views").ConfigureAwait(false);
            await Console.Error.WriteLineAsync(ex.Message).ConfigureAwait(false);
        }
    }

    public void Dispose()
    {
        _jellyfinApiClient.Dispose();
    }
}
