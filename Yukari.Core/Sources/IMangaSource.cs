using Yukari.Core.Models;

namespace Yukari.Core.Sources
{
    public interface IMangaSource
    {
        string Name { get; }

        Task<List<Comic>> SearchAsync(string query);
        Task<List<Comic>> GetTrendingAsync();
        Task<Comic?> GetDetailsAsync(string mangaId);
        Task<List<Chapter>> GetAllChaptersAsync(string mangaId);
        Task<List<ChapterPage>> GetChapterPagesAsync(string chapterId);
    }
}
