namespace Yukari.Core.Models.Settings;

public abstract record SourceSetting
{
    public required string Key { get; init; }
    public required string Header { get; init; }
    public string? Description { get; init; }
}
