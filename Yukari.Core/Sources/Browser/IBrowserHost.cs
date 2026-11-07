namespace Yukari.Core.Sources.Browser;

/// <summary>
/// Defines a UI host capable of embedding and displaying a web browser view for interactive challenge resolution.
/// </summary>
public interface IBrowserHost
{
    /// <summary>
    /// Attaches the underlying browser control instance to the visual tree of the host.
    /// </summary>
    /// <param name="browser">The platform-specific browser control to attach.</param>
    void AttachBrowser(object browser);

    /// <summary>
    /// Detaches the underlying browser control instance from the visual tree of the host.
    /// </summary>
    /// <param name="browser">The platform-specific browser control to detach.</param>
    void DetachBrowser(object browser);

    /// <summary>
    /// Makes the attached browser visible to the user so they can complete an interactive challenge.
    /// </summary>
    void ShowBrowser();

    /// <summary>
    /// Hides the attached browser from the user while background navigation or script evaluation takes place.
    /// </summary>
    void HideBrowser();

    /// <summary>
    /// Occurs when the user manually cancels an interactive browser challenge.
    /// </summary>
    event Action? UserCancelledInteraction;
}
