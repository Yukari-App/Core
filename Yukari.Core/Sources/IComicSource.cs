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

        Task<IReadOnlyList<Comic>> SearchAsync(
            string query,
            IReadOnlyDictionary<string, IReadOnlyList<string>> filters,
            CancellationToken ct = default
        );
        Task<IReadOnlyList<Comic>> GetTrendingAsync(
            IReadOnlyDictionary<string, IReadOnlyList<string>> filters,
            CancellationToken ct = default
        );
        Task<Comic?> GetDetailsAsync(string comicId, CancellationToken ct = default);
        Task<Chapter?> GetChapterDetailsAsync(
            string comicId,
            string chapterId,
            CancellationToken ct = default
        );
        Task<IReadOnlyList<Chapter>> GetAllChaptersAsync(
            string comicId,
            string language,
            CancellationToken ct = default
        );
        Task<IReadOnlyList<ChapterPage>> GetChapterPagesAsync(
            string comicId,
            string chapterId,
            CancellationToken ct = default
        );
    }
}
