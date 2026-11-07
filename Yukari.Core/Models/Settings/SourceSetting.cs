namespace Yukari.Core.Models.Settings;

/// <summary>
/// Base type for a user-configurable setting declared by an <see cref="Sources.IConfigurableSource"/>.
/// </summary>
public abstract record SourceSetting
{
    /// <summary>
    /// Gets the unique identifier key used to persist and retrieve this setting via <see cref="Sources.ISourceSettings"/>.
    /// </summary>
    public required string Key { get; init; }

    /// <summary>
    /// Gets the primary display title shown for this setting in the configuration dialog.
    /// </summary>
    public required string Header { get; init; }

    /// <summary>
    /// Gets an optional explanatory description shown beneath the header in the configuration dialog.
    /// </summary>
    public string? Description { get; init; }
}
