namespace Yukari.Core.Models;

public record Filter(
    string Key,
    string DisplayName,
    IReadOnlyList<FilterOption> Options,
    bool AllowMultiple
);
