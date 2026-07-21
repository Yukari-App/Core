namespace Yukari.Core.Sources;

public interface ISharedHttpClient
{
    Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken ct = default);
}
