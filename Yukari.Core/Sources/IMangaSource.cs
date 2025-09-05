using Yukari.Core.Models;

namespace Yukari.Core.Sources
{
    public interface IMangaSource
    {
        string Name { get; }

        Task<List<Manga>> SearchAsync(string query);
        Task<List<Manga>> GetTrendingAsync();
        Task<Manga?> GetDetailsAsync(string mangaId);
        Task<List<Chapter>> GetAllChaptersAsync(string mangaId);
        Task<List<ChapterPage>> GetChapterPagesAsync(string chapterId);
    }
}
