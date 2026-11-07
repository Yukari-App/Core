namespace Yukari.Core.Sources.Http;

/// <summary>
/// Provides a shared, host-managed HTTP client abstraction for comic source plugins.
/// </summary>
/// <remarks>
/// The host sends requests with <see cref="HttpCompletionOption.ResponseHeadersRead"/> and applies a default
/// <c>User-Agent</c> header when none is set on the <see cref="HttpRequestMessage"/>. Plugins may attach
/// custom per-request headers (such as <c>User-Agent</c>, <c>Referer</c>, <c>Cookie</c>, or <c>Authorization</c>)
/// directly to each request and are responsible for disposing the returned <see cref="HttpResponseMessage"/>.
/// </remarks>
public interface ISharedHttpClient
{
    /// <summary>
    /// Sends an HTTP request as an asynchronous operation.
    /// </summary>
    /// <param name="request">The HTTP request message to send.</param>
    /// <param name="ct">A token to cancel the asynchronous operation.</param>
    /// <returns>The <see cref="HttpResponseMessage"/> received from the server.</returns>
    Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken ct = default);
}
