using System;
using Jellyfin.Sdk.Generated;
using Microsoft.Kiota.Abstractions;

namespace Jellyfin.Sdk;

/// <summary>
/// The Jellyfin api client.
/// </summary>
public class JellyfinApiClient : BaseJellyfinApiClient, IDisposable
{
    private readonly JellyfinSdkSettings _jellyfinSdkSettings;
    private readonly IRequestAdapter _requestAdapter;

    /// <summary>
    /// Initializes a new instance of the <see cref="JellyfinApiClient"/> class.
    /// </summary>
    /// <param name="requestAdapter">The request adapter.</param>
    /// <param name="jellyfinSdkSettings">The Jellyfin sdk settings.</param>
    public JellyfinApiClient(IRequestAdapter requestAdapter, JellyfinSdkSettings jellyfinSdkSettings)
        : base(requestAdapter)
    {
        _jellyfinSdkSettings = jellyfinSdkSettings;
        _requestAdapter = requestAdapter;
    }

    /// <summary>
    /// Update the current api client.
    /// </summary>
    /// <remarks>
    /// Only required if changing the server address.
    /// </remarks>
    public void Update()
        => RequestAdapter.BaseUrl = _jellyfinSdkSettings.ServerUrl;

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
