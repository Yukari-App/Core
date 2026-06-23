namespace Yukari.Core.Models;

// If AllowMultiple is false, do not mark more than one FilterOption as Default;
// if you do, the default will always be the first one.
public record Filter(
    string Key,
    string DisplayName,
    IReadOnlyList<FilterOption> Options,
    bool AllowMultiple
);
