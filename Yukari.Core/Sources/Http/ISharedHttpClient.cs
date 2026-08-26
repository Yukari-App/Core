namespace Yukari.Core.Sources.Http;

public interface ISharedHttpClient
{
    Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken ct = default);
}
