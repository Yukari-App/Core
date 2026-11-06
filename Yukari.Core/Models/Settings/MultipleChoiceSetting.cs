namespace Yukari.Core.Models.Settings;

public record MultipleChoiceSetting : SourceSetting
{
    public required IReadOnlyList<SettingOption> Options { get; init; }
    public IReadOnlyList<string>? DefaultKeys { get; init; }
}
