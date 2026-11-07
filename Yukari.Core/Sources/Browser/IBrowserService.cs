namespace Yukari.Core.Sources.Browser;

/// <summary>
/// Provides headless and interactive browser capabilities (such as anti-bot challenge resolution and JavaScript evaluation)
/// to comic sources that implement <see cref="IRequiresBrowser"/>.
/// </summary>
public interface IBrowserService : IAsyncDisposable
{
    /// <summary>
    /// Configures the UI host used to display the browser when user interaction is required.
    /// </summary>
    /// <param name="host">The <see cref="IBrowserHost"/> implementation provided by the application window.</param>
    void SetHost(IBrowserHost host);

    /// <summary>
    /// Navigates to the specified URL to resolve an anti-bot or CAPTCHA challenge and extracts the resulting session cookies.
    /// </summary>
    /// <remarks>
    /// The browser first attempts to resolve the challenge silently in the background for up to <paramref name="autoResolveTimeout"/>.
    /// If the challenge is still unresolved after that window and overall <paramref name="timeout"/> has not elapsed,
    /// the host calls <see cref="IBrowserHost.ShowBrowser"/> so the user can complete the challenge interactively.
    /// </remarks>
    /// <param name="url">The target URL protected by the challenge.</param>
    /// <param name="timeout">
    /// The maximum overall time allowed to resolve the challenge before throwing a <see cref="TimeoutException"/>.
    /// Defaults to 60 seconds when <see langword="null"/>.
    /// </param>
    /// <param name="challengeDetectionScript">
    /// An optional JavaScript snippet polled periodically (every 500 ms) that must return <see langword="true"/>
    /// (<c>"true"</c>) once the challenge has been resolved and is no longer active (for example, <c>return !isChallenge;</c>).
    /// When <see langword="null"/> or empty, the service falls back to waiting for browser navigations to settle.
    /// </param>
    /// <param name="autoResolveTimeout">
    /// The time to wait for automatic background resolution before revealing the browser for manual user interaction.
    /// Defaults to 10 seconds when <see langword="null"/>.
    /// </param>
    /// <param name="ct">A token to cancel the asynchronous operation.</param>
    /// <returns>A <see cref="BrowserSession"/> containing the cookies and User-Agent from the resolved session.</returns>
    /// <exception cref="TimeoutException">Thrown if the challenge is not resolved within <paramref name="timeout"/>.</exception>
    Task<BrowserSession> ResolveChallengeAsync(
        string url,
        TimeSpan? timeout = null,
        string? challengeDetectionScript = null,
        TimeSpan? autoResolveTimeout = null,
        CancellationToken ct = default
    );

    /// <summary>
    /// Navigates to the specified URL in the background (if not already on that URL) and evaluates a JavaScript snippet on the loaded page.
    /// </summary>
    /// <param name="url">The URL of the page to load.</param>
    /// <param name="script">The JavaScript code to execute in the context of the loaded page.</param>
    /// <param name="ct">A token to cancel the asynchronous operation.</param>
    /// <returns>
    /// The JSON-serialized result returned by the script (for example, a quoted JSON string when the script returns a string),
    /// or <see langword="null"/> if evaluation produced no value.
    /// </returns>
    Task<string?> EvaluateScriptAsync(string url, string script, CancellationToken ct = default);
}
