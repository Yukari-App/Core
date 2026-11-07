namespace Yukari.Core.Models.Settings;

/// <summary>
/// Represents a multi-selection setting where zero or more <see cref="SettingOption"/> items can be toggled.
/// Retrieve the selected option keys via <see cref="Sources.ISourceSettings.GetStringList"/>.
/// </summary>
public record MultipleChoiceSetting : SourceSetting
{
    /// <summary>
    /// Gets the available options that the user can toggle.
    /// </summary>
    public required IReadOnlyList<SettingOption> Options { get; init; }

    /// <summary>
    /// Gets the keys of the options selected by default when the user has not configured this setting.
    /// </summary>
    public IReadOnlyList<string>? DefaultKeys { get; init; }
}
