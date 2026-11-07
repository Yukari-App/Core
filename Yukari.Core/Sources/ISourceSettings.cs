namespace Yukari.Core.Sources;

/// <summary>
/// Provides typed, read-only access to the current setting values of an <see cref="IConfigurableSource"/>.
/// </summary>
/// <remarks>
/// If a requested key has not been saved by the user or its stored value cannot be parsed as the
/// requested type, the accessor returns the setting's declared default value from
/// <see cref="IConfigurableSource.Settings"/>, or the provided <c>defaultValue</c> fallback when the
/// key is not declared in the schema.
/// </remarks>
public interface ISourceSettings
{
    /// <summary>
    /// Gets the boolean value of a <see cref="Models.Settings.ToggleSetting"/>.
    /// </summary>
    /// <param name="key">The unique key of the setting.</param>
    /// <param name="defaultValue">The fallback value returned if the key is not declared in the schema.</param>
    /// <returns>The configured or default boolean value.</returns>
    bool GetBool(string key, bool defaultValue = false);

    /// <summary>
    /// Gets the string value of a <see cref="Models.Settings.TextSetting"/>,
    /// <see cref="Models.Settings.PasswordSetting"/>, or <see cref="Models.Settings.SingleChoiceSetting"/>.
    /// </summary>
    /// <param name="key">The unique key of the setting.</param>
    /// <param name="defaultValue">The fallback value returned if the key is not declared in the schema.</param>
    /// <returns>The configured or default string value.</returns>
    string GetString(string key, string defaultValue = "");

    /// <summary>
    /// Gets the 32-bit integer value of a <see cref="Models.Settings.NumberSetting"/>.
    /// </summary>
    /// <param name="key">The unique key of the setting.</param>
    /// <param name="defaultValue">The fallback value returned if the key is not declared in the schema.</param>
    /// <returns>The configured or default integer value, clamped to the setting's declared bounds.</returns>
    int GetInt(string key, int defaultValue = 0);

    /// <summary>
    /// Gets the double-precision floating-point value of a <see cref="Models.Settings.NumberSetting"/>.
    /// </summary>
    /// <param name="key">The unique key of the setting.</param>
    /// <param name="defaultValue">The fallback value returned if the key is not declared in the schema.</param>
    /// <returns>The configured or default floating-point value, clamped to the setting's declared bounds.</returns>
    double GetDouble(string key, double defaultValue = 0.0);

    /// <summary>
    /// Gets the list of selected option keys for a <see cref="Models.Settings.MultipleChoiceSetting"/>.
    /// </summary>
    /// <param name="key">The unique key of the setting.</param>
    /// <param name="defaultValue">The fallback list returned if the key is not declared in the schema.</param>
    /// <returns>A read-only list of the selected option keys.</returns>
    IReadOnlyList<string> GetStringList(string key, IReadOnlyList<string>? defaultValue = null);
}
