namespace Yukari.Core.Sources;

public interface IRequiresHttpClient
{
    void SetHttpClient(ISharedHttpClient httpClient);
}
