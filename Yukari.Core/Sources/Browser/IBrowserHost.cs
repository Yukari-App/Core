namespace Yukari.Core.Sources.Browser;

public interface IBrowserHost
{
    void AttachBrowser(object browser);
    void DetachBrowser(object browser);

    void ShowBrowser();
    void HideBrowser();

    event Action? UserCancelledInteraction;
}
