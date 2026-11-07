namespace Yukari.Core.Models.Settings;

/// <summary>
/// Represents a single-line plain-text input setting.
/// Retrieve its value via <see cref="Sources.ISourceSettings.GetString"/>.
/// </summary>
public record TextSetting : SourceSetting
{
    /// <summary>
    /// Gets the optional watermark placeholder text shown when the input box is empty.
    /// </summary>
    public string? Placeholder { get; init; }

    /// <summary>
    /// Gets the default string value used when the user has not configured this setting.
    /// </summary>
    public string DefaultValue { get; init; } = string.Empty;
}
