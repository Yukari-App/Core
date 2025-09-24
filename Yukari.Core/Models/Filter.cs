namespace Yukari.Core.Models
{
    public class Filter
    {
        public string Key { get; init; }
        public string DisplayName { get; init; }
        public List<string> Options { get; init; }
        public bool AllowMultiple { get; init; }
    }
}
