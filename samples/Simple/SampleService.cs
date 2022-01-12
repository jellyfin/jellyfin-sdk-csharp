using System;
using System.Threading.Tasks;
using Jellyfin.Sdk;
using SystemException = Jellyfin.Sdk.SystemException;

namespace Simple;

/// <summary>
/// Sample Jellyfin service.
/// </summary>
public class SampleService
{
    private readonly SdkClientSettings _sdkClientSettings;
    private readonly ISystemClient _systemClient;
    private readonly IUserClient _userClient;
    private readonly IUserViewsClient _userViewsClient;

    /// <summary>
    /// Initializes a new instance of the <see cref="SampleService"/> class.
    /// </summary>
    /// <param name="sdkClientSettings">Instance of the <see cref="_sdkClientSettings"/>.</param>
    /// <param name="systemClient">Instance of the <see cref="ISystemClient"/> interface.</param>
    /// <param name="userClient">Instance of the <see cref="IUserClient"/> interface.</param>
    /// <param name="userViewsClient">Instance of the <see cref="IUserViewsClient"/> interface.</param>
    public SampleService(
        SdkClientSettings sdkClientSettings,
        ISystemClient systemClient,
        IUserClient userClient,
        IUserViewsClient userViewsClient)
    {
        _sdkClientSettings = sdkClientSettings;
        _systemClient = systemClient;
        _userClient = userClient;
        _userViewsClient = userViewsClient;
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

            _sdkClientSettings.BaseUrl = host;
            try
            {
                // Get public system info to verify that the url points to a Jellyfin server.
                var systemInfo = await _systemClient.GetPublicSystemInfoAsync()
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

                Console.WriteLine($"Logging into {_sdkClientSettings.BaseUrl}");

                // Authenticate user.
                var authenticationResult = await _userClient.AuthenticateUserByNameAsync(new AuthenticateUserByName
                    {
                        Username = username,
                        Pw = password
                    })
                    .ConfigureAwait(false);

                _sdkClientSettings.AccessToken = authenticationResult.AccessToken;
                userDto = authenticationResult.User;
                Console.WriteLine("Authentication success.");
                Console.WriteLine($"Welcome to Jellyfin - {userDto.Name}");
                validUser = true;
            }
            catch (UserException ex)
            {
                await Console.Error.WriteLineAsync("Error authenticating.").ConfigureAwait(false);
                await Console.Error.WriteLineAsync(ex.Message).ConfigureAwait(false);
            }
        }
        while (!validUser);

        await PrintViews(userDto.Id)
            .ConfigureAwait(false);
    }

    private async Task PrintViews(Guid userId)
    {
        try
        {
            var views = await _userViewsClient.GetUserViewsAsync(userId)
                .ConfigureAwait(false);
            Console.WriteLine("Printing Views:");
            foreach (var view in views.Items)
            {
                Console.WriteLine($"{view.Id} - {view.Name}");
            }
        }
        catch (UserViewsException ex)
        {
            await Console.Error.WriteLineAsync("Error getting user views").ConfigureAwait(false);
            await Console.Error.WriteLineAsync(ex.Message).ConfigureAwait(false);
        }
    }
}
