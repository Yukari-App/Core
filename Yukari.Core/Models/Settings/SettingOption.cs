namespace Yukari.Core.Models.Settings;

/// <summary>
/// Represents an individual selectable option within a <see cref="SingleChoiceSetting"/> or <see cref="MultipleChoiceSetting"/>.
/// </summary>
/// <param name="Key">The unique identifier key stored and returned by <see cref="Sources.ISourceSettings"/> when selected.</param>
/// <param name="DisplayName">The human-readable label displayed in the UI.</param>
public record SettingOption(string Key, string DisplayName);
