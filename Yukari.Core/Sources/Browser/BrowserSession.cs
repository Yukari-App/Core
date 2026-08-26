namespace Yukari.Core.Sources.Browser;

public record BrowserSession(IReadOnlyDictionary<string, string> Cookies, string UserAgent);
