namespace Yukari.Core.Models.Settings;

/// <summary>
/// Represents a sensitive credential setting (such as a password or API token) that is stored encrypted
/// by the host and never exported in library backups.
/// Retrieve its value via <see cref="Sources.ISourceSettings.GetString"/>.
/// </summary>
public record PasswordSetting : SourceSetting
{
    /// <summary>
    /// Gets the optional watermark placeholder text shown when the password box is empty.
    /// </summary>
    public string? Placeholder { get; init; }
}
