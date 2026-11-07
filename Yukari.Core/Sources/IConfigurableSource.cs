using Yukari.Core.Models.Settings;

namespace Yukari.Core.Sources;

/// <summary>
/// Defines a comic source that exposes user-configurable settings.
/// </summary>
public interface IConfigurableSource
{
    /// <summary>
    /// Gets the list of settings supported by this comic source.
    /// </summary>
    IReadOnlyList<SourceSetting> Settings { get; }

    /// <summary>
    /// Applies the configured settings to the source.
    /// <para>
    /// This method is called by the host immediately after instantiation (before first use)
    /// and again whenever the user saves changes in the settings dialog.
    /// </para>
    /// <para>
    /// It may be called on the UI thread while requests are actively in flight. Implementations
    /// must be fast, non-blocking, and perform no I/O. If multiple settings depend on each other,
    /// consider grouping them into an immutable state object and assigning it in a single write.
    /// </para>
    /// <para>
    /// Keys not declared in <see cref="Settings"/> are ignored by the host. If a key's stored type
    /// does not match the setting definition, the host falls back to the setting's declared default.
    /// </para>
    /// </summary>
    /// <param name="settings">The provider used to access current setting values.</param>
    void ApplySettings(ISourceSettings settings);
}
