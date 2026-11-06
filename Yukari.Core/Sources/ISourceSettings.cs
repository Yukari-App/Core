namespace Yukari.Core.Sources;

public interface ISourceSettings
{
    bool GetBool(string key, bool defaultValue = false);
    string GetString(string key, string defaultValue = "");
    int GetInt(string key, int defaultValue = 0);
    double GetDouble(string key, double defaultValue = 0.0);
    IReadOnlyList<string> GetStringList(string key, IReadOnlyList<string>? defaultValue = null);
}
