namespace Yukari.Core.Models.Settings;

public record ToggleSetting : SourceSetting
{
    public bool DefaultValue { get; init; }
}
