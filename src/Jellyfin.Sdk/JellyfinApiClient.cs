using System;
using Jellyfin.Sdk.Generated;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Extensions;

namespace Jellyfin.Sdk;

/// <summary>
/// The Jellyfin api client.
/// </summary>
public class JellyfinApiClient : BaseJellyfinApiClient, IDisposable
{
    private readonly IRequestAdapter _requestAdapter;

    /// <summary>
    /// Initializes a new instance of the <see cref="JellyfinApiClient"/> class.
    /// </summary>
    /// <param name="requestAdapter">The request adapter.</param>
    public JellyfinApiClient(IRequestAdapter requestAdapter)
        : base(requestAdapter)
    {
        _requestAdapter = requestAdapter;
    }

    /// <summary>
    /// Build the uri from the request information.
    /// </summary>
    /// <param name="requestInformation">The request information.</param>
    /// <returns>The built uri.</returns>
    public Uri BuildUri(RequestInformation requestInformation)
    {
        if (!string.IsNullOrEmpty(_requestAdapter.BaseUrl))
        {
            requestInformation.PathParameters.AddOrReplace("baseurl", _requestAdapter.BaseUrl!);
        }

        return requestInformation.URI;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Dispose managed resources.
    /// </summary>
    /// <param name="disposing">Whether to dispose.</param>
    protected virtual void Dispose(bool disposing)
    {
        if (!disposing)
        {
            return;
        }

        if (_requestAdapter is IDisposable disposable)
        {
            disposable.Dispose();
        }
    }
}
