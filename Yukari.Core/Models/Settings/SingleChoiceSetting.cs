namespace Yukari.Core.Models.Settings;

public record SingleChoiceSetting : SourceSetting
{
    public required IReadOnlyList<SettingOption> Options { get; init; }
    public string? DefaultKey { get; init; }
}
