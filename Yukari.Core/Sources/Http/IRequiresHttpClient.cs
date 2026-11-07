namespace Yukari.Core.Sources.Http;

/// <summary>
/// Indicates that a <see cref="IComicSource"/> uses a host-provided <see cref="ISharedHttpClient"/>
/// to perform HTTP requests.
/// </summary>
public interface IRequiresHttpClient
{
    /// <summary>
    /// Injects the host's <see cref="ISharedHttpClient"/> into the comic source after instantiation.
    /// </summary>
    /// <param name="httpClient">The shared HTTP client wrapper provided by the host.</param>
    void SetHttpClient(ISharedHttpClient httpClient);
}
