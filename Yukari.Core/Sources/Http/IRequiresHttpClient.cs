namespace Yukari.Core.Sources.Http;

public interface IRequiresHttpClient
{
    void SetHttpClient(ISharedHttpClient httpClient);
}
