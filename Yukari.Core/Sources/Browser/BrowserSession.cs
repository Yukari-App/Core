namespace Yukari.Core.Sources.Browser;

/// <summary>
/// Represents the HTTP cookies and User-Agent string captured from a browser session after resolving a web challenge.
/// </summary>
/// <param name="Cookies">A read-only dictionary of cookie names and values extracted for the target domain.</param>
/// <param name="UserAgent">The User-Agent header string used by the browser during the session.</param>
public record BrowserSession(IReadOnlyDictionary<string, string> Cookies, string UserAgent);
