namespace Yukari.Core.Models;

public record Filter(
    string Key,
    string DisplayName,
    List<FilterOption> Options,
    bool AllowMultiple
);
