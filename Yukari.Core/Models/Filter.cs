namespace Yukari.Core.Models
{
    public record Filter(
            string Key,
            string DisplayName,
            List<string> Options,
            bool AllowMultiple
        );
}
