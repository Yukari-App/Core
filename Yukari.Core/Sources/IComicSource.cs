using Yukari.Core.Models;

namespace Yukari.Core.Sources
{
    public interface IComicSource : IAsyncDisposable
    {
        string Name { get; }
        string Version { get; }
        string? LogoUrl { get; }
        string? Description { get; }

        IReadOnlyList<Filter> Filters { get; }
        IReadOnlyDictionary<string, string> Languages { get; }

        Task<IReadOnlyList<Comic>> SearchAsync(string query, Dictionary<string, IReadOnlyList<string>> filters);
        Task<IReadOnlyList<Comic>> GetTrendingAsync(Dictionary<string, IReadOnlyList<string>> filters);
        Task<Comic?> GetDetailsAsync(string mangaId);
        Task<IReadOnlyList<Chapter>> GetAllChaptersAsync(string mangaId, string language);
        Task<IReadOnlyList<ChapterPage>> GetChapterPagesAsync(string chapterId);
    }
}
