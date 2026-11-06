namespace Yukari.Core.Models.Settings;

public record PasswordSetting : SourceSetting
{
    public string? Placeholder { get; init; }
}
