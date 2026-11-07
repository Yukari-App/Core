namespace Yukari.Core.Models.Settings;

/// <summary>
/// Represents a single-selection dropdown setting chosen from a fixed list of <see cref="SettingOption"/> items.
/// Retrieve the selected option key via <see cref="Sources.ISourceSettings.GetString"/>.
/// </summary>
public record SingleChoiceSetting : SourceSetting
{
    /// <summary>
    /// Gets the available options that the user can choose from.
    /// </summary>
    public required IReadOnlyList<SettingOption> Options { get; init; }

    /// <summary>
    /// Gets the key of the option selected by default. If <see langword="null"/> or not found in <see cref="Options"/>,
    /// the host falls back to the first option in <see cref="Options"/>.
    /// </summary>
    public string? DefaultKey { get; init; }
}
