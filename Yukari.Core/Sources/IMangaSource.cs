using Yukari.Core.Models;

namespace Yukari.Core.Sources
{
    public interface IMangaSource : IAsyncDisposable
    {
        string Name { get; }
        string? LogoUrl { get; }
        string? Description { get; }

        IReadOnlyList<Filter> Filters { get; }
        IReadOnlyDictionary<string, string> Languages { get; }

        Task<List<Comic>> SearchAsync(string query, Dictionary<string, List<string>> filters);
        Task<List<Comic>> GetTrendingAsync(Dictionary<string, List<string>> filters);
        Task<Comic?> GetDetailsAsync(string mangaId);
        Task<List<Chapter>> GetAllChaptersAsync(string mangaId, string language);
        Task<List<ChapterPage>> GetChapterPagesAsync(string chapterId);
    }
}
