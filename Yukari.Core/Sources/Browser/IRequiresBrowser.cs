namespace Yukari.Core.Sources.Browser;

/// <summary>
/// Indicates that a <see cref="IComicSource"/> requires access to an <see cref="IBrowserService"/>
/// for web scraping or challenge resolution.
/// </summary>
public interface IRequiresBrowser
{
    /// <summary>
    /// Injects the host's <see cref="IBrowserService"/> into the comic source after instantiation.
    /// </summary>
    /// <param name="browser">The browser service instance provided by the host.</param>
    void SetBrowser(IBrowserService browser);
}
