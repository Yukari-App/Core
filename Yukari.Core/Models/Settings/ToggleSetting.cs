namespace Yukari.Core.Models.Settings;

/// <summary>
/// Represents a boolean on/off toggle setting.
/// Retrieve its value via <see cref="Sources.ISourceSettings.GetBool"/>.
/// </summary>
public record ToggleSetting : SourceSetting
{
    /// <summary>
    /// Gets the default boolean value used when the user has not configured this setting.
    /// </summary>
    public bool DefaultValue { get; init; }
}
