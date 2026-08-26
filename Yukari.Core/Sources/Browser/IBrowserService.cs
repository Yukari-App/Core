namespace Yukari.Core.Sources.Browser;

public interface IBrowserService : IAsyncDisposable
{
    void SetHost(IBrowserHost host);

    Task<BrowserSession?> ResolveChallengeAsync(
        string url,
        TimeSpan? timeout = null,
        CancellationToken ct = default
    );

    Task<string?> EvaluateScriptAsync(string url, string script, CancellationToken ct = default);
}
