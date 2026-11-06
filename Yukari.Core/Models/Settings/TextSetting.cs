namespace Yukari.Core.Models.Settings;

public record TextSetting : SourceSetting
{
    public string? Placeholder { get; init; }
    public string DefaultValue { get; init; } = string.Empty;
}
