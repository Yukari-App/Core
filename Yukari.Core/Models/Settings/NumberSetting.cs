namespace Yukari.Core.Models.Settings;

/// <summary>
/// Represents a numeric input setting with optional bounds and step increment.
/// Retrieve its value via <see cref="Sources.ISourceSettings.GetInt"/> or <see cref="Sources.ISourceSettings.GetDouble"/>.
/// </summary>
public record NumberSetting : SourceSetting
{
    /// <summary>
    /// Gets the optional watermark placeholder text shown in the number box.
    /// </summary>
    public string? Placeholder { get; init; }

    /// <summary>
    /// Gets the default numeric value used when the user has not configured this setting.
    /// </summary>
    public double DefaultValue { get; init; }

    /// <summary>
    /// Gets the optional inclusive minimum value allowed for this setting.
    /// </summary>
    public double? Minimum { get; init; }

    /// <summary>
    /// Gets the optional inclusive maximum value allowed for this setting.
    /// </summary>
    public double? Maximum { get; init; }

    /// <summary>
    /// Gets the optional step increment used by the spin buttons in the UI.
    /// </summary>
    public double? Step { get; init; }
}
