namespace Yukari.Core.Models;

/// <summary>
/// Represents an individual selectable option within a <see cref="Filter"/>.
/// </summary>
/// <param name="Key">The identifier key sent to the source when this option is selected.</param>
/// <param name="DisplayName">The human-readable label displayed in the UI.</param>
/// <param name="Default"><see langword="true"/> if this option is selected by default; otherwise, <see langword="false"/>.</param>
public record FilterOption(string Key, string DisplayName, bool Default);
