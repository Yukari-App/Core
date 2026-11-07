namespace Yukari.Core.Models;

/// <summary>
/// Represents a search or browse filter exposed by a <see cref="Sources.IComicSource"/>.
/// </summary>
/// <remarks>
/// If <paramref name="AllowMultiple"/> is <see langword="false"/>, do not mark more than one
/// <see cref="FilterOption"/> as <see cref="FilterOption.Default"/>; if multiple options are marked
/// as default, the host will always select the first one.
/// </remarks>
/// <param name="Key">The unique identifier key of the filter passed back to query methods.</param>
/// <param name="DisplayName">The human-readable label displayed in the filter dialog.</param>
/// <param name="Options">The selectable options belonging to this filter.</param>
/// <param name="AllowMultiple">
/// <see langword="true"/> if multiple options can be selected simultaneously;
/// <see langword="false"/> if only a single option can be selected at a time.
/// </param>
public record Filter(
    string Key,
    string DisplayName,
    IReadOnlyList<FilterOption> Options,
    bool AllowMultiple
);
