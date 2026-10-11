<h1 align="center">Jellyfin SDK for C#</h1>
<h3 align="center">Part of the <a href="https://jellyfin.org">Jellyfin Project</a></h3>

---

<p align="center">
<img alt="Logo Banner" src="https://raw.githubusercontent.com/jellyfin/jellyfin-ux/master/branding/SVG/banner-logo-solid.svg?sanitize=true"/>
<br/>
<br/>
<a href="https://github.com/jellyfin/jellyfin-sdk-csharp">
<img alt="MIT License" src="https://img.shields.io/github/license/jellyfin/jellyfin-sdk-csharp.svg"/>
</a>
<a href="https://opencollective.com/jellyfin">
<img alt="Donate" src="https://img.shields.io/opencollective/all/jellyfin.svg?label=backers"/>
</a>
<a href="https://features.jellyfin.org">
<img alt="Feature Requests" src="https://img.shields.io/badge/fider-vote%20on%20features-success.svg"/>
</a>
<a href="https://matrix.to/#/+jellyfin:matrix.org">
<img alt="Chat on Matrix" src="https://img.shields.io/matrix/jellyfin:matrix.org.svg?logo=matrix"/>
</a>
<a href="https://www.reddit.com/r/jellyfin">
<img alt="Join our Subreddit" src="https://img.shields.io/badge/reddit-r%2Fjellyfin-%23FF5700.svg"/>
</a>
<a href="https://www.nuget.org/packages/Jellyfin.Sdk/">
<img alt="Nuget" src="https://img.shields.io/nuget/v/Jellyfin.Sdk?style=flat-square&label=nuget"/>
</a>
</p>

- Uses [Kiota](https://github.com/microsoft/kiota) for generation.

### WebSockets

`JellyfinWebSocketClient` receives server messages such as library changes, remote control commands and session updates.
It uses the server URL and access token from `JellyfinSdkSettings`.

```csharp
using var webSocket = new JellyfinWebSocketClient(sdkSettings);

using var subscription = webSocket.Subscribe<LibraryChangedMessage>(message =>
    Console.WriteLine($"{message.Data?.ItemsAdded?.Count} items added"));
```

- The connection opens on the first subscription and closes 5 seconds after the last subscription is disposed.
- Subscribing to `SessionsMessage`, `ActivityLogEntryMessage` or `ScheduledTasksInfoMessage` sends the start and stop
  messages to the server for you.
- Keep alive messages are handled for you. `SubscribeAll` receives every other message type, but it does not start the
  periodic sessions, activity log or scheduled task messages. Those arrive only while a `Subscribe` for that type exists.
- Each connection attempt reads the server URL and access token from `JellyfinSdkSettings`. Call `Reconnect()` after
  changing them. A dropped connection reconnects with exponential backoff, configurable through
  `JellyfinWebSocketOptions.ReconnectPolicy`.
- Handlers run on the receive loop and should return quickly. Exceptions thrown by handlers are raised through
  `ErrorOccurred`.

Documentation WIP.
https://img.shields.io/nuget/v/Jellyfin.Sdk?style=flat-square&label=nuget
