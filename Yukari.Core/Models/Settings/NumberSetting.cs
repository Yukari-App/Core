namespace Yukari.Core.Models.Settings;

public record NumberSetting : SourceSetting
{
    public string? Placeholder { get; init; }
    public double DefaultValue { get; init; }
    public double? Minimum { get; init; }
    public double? Maximum { get; init; }
    public double? Step { get; init; }
}
