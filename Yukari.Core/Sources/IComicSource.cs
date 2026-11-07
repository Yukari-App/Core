using Yukari.Core.Models;

namespace Yukari.Core.Sources;

/// <summary>
/// Defines the core contract for a comic source plugin in Yukari.
/// </summary>
public interface IComicSource : IAsyncDisposable
{
    /// <summary>
    /// Gets the search and browse filters supported by this comic source.
    /// </summary>
    IReadOnlyList<Filter> Filters { get; }

    /// <summary>
    /// Gets the languages supported by this comic source, mapped from source-defined language key
    /// (for example, <c>"en"</c>, <c>"pt-br"</c>, or <c>"es-la"</c>) to human-readable display name.
    /// </summary>
    IReadOnlyDictionary<string, string> Languages { get; }

    /// <summary>
    /// Searches for comics matching the specified query and filter selections.
    /// </summary>
    /// <remarks>
    /// Items returned from search only need to populate summary card fields (<see cref="Comic.Id"/>,
    /// <see cref="Comic.Title"/>, <see cref="Comic.CoverImageUrl"/>, and optionally <see cref="Comic.Status"/>);
    /// full metadata is fetched later via <see cref="GetDetailsAsync"/>.
    /// </remarks>
    /// <param name="query">The search query text entered by the user.</param>
    /// <param name="filters">A dictionary mapping filter keys to their selected option keys.</param>
    /// <param name="page">The 1-based page number of results to retrieve.</param>
    /// <param name="ct">A token to cancel the asynchronous operation.</param>
    /// <returns>A read-only list of matching <see cref="Comic"/> items for the requested page.</returns>
    Task<IReadOnlyList<Comic>> SearchAsync(
        string query,
        IReadOnlyDictionary<string, IReadOnlyList<string>> filters,
        int page = 1,
        CancellationToken ct = default
    );

    /// <summary>
    /// Retrieves trending or popular comics matching the specified filter selections.
    /// </summary>
    /// <remarks>
    /// Items returned from trending only need to populate summary card fields (<see cref="Comic.Id"/>,
    /// <see cref="Comic.Title"/>, <see cref="Comic.CoverImageUrl"/>, and optionally <see cref="Comic.Status"/>);
    /// full metadata is fetched later via <see cref="GetDetailsAsync"/>.
    /// </remarks>
    /// <param name="filters">A dictionary mapping filter keys to their selected option keys.</param>
    /// <param name="page">The 1-based page number of results to retrieve.</param>
    /// <param name="ct">A token to cancel the asynchronous operation.</param>
    /// <returns>A read-only list of trending <see cref="Comic"/> items for the requested page.</returns>
    Task<IReadOnlyList<Comic>> GetTrendingAsync(
        IReadOnlyDictionary<string, IReadOnlyList<string>> filters,
        int page = 1,
        CancellationToken ct = default
    );

    /// <summary>
    /// Retrieves the full metadata details of a specific comic.
    /// </summary>
    /// <param name="comicId">The unique identifier of the comic within this source.</param>
    /// <param name="ct">A token to cancel the asynchronous operation.</param>
    /// <returns>The <see cref="Comic"/> details, or <see langword="null"/> if the comic was not found.</returns>
    Task<Comic?> GetDetailsAsync(string comicId, CancellationToken ct = default);

    /// <summary>
    /// Retrieves all available chapters for a specific comic in the given language.
    /// </summary>
    /// <remarks>
    /// Implementations should return chapters in ascending chronological/reading order (oldest or first chapter first),
    /// as the host assigns sequential sort order from the returned list index.
    /// </remarks>
    /// <param name="comicId">The unique identifier of the comic within this source.</param>
    /// <param name="language">The source-defined language key (from <see cref="Languages"/> or <see cref="Comic.Langs"/>) to filter chapters by.</param>
    /// <param name="ct">A token to cancel the asynchronous operation.</param>
    /// <returns>A read-only list of <see cref="Chapter"/> items in ascending reading order.</returns>
    Task<IReadOnlyList<Chapter>> GetAllChaptersAsync(
        string comicId,
        string language,
        CancellationToken ct = default
    );

    /// <summary>
    /// Retrieves the ordered list of pages for a specific chapter.
    /// </summary>
    /// <param name="comicId">The unique identifier of the comic within this source.</param>
    /// <param name="chapterId">The unique identifier of the chapter within this source.</param>
    /// <param name="ct">A token to cancel the asynchronous operation.</param>
    /// <returns>A read-only list of <see cref="ChapterPage"/> items for the chapter.</returns>
    Task<IReadOnlyList<ChapterPage>> GetChapterPagesAsync(
        string comicId,
        string chapterId,
        CancellationToken ct = default
    );

    /// <summary>
    /// Downloads the raw image bytes for a logo, comic cover, or chapter page URL belonging to this source.
    /// </summary>
    /// <param name="imageUrl">
    /// The image URL previously supplied by this source via <see cref="ComicSourceMetadataAttribute.LogoUrl"/>,
    /// <see cref="Comic.CoverImageUrl"/>, or <see cref="ChapterPage.ImageUrl"/>.
    /// </param>
    /// <param name="ct">A token to cancel the asynchronous operation.</param>
    /// <returns>The raw image byte array, or <see langword="null"/> if the image could not be fetched.</returns>
    Task<byte[]?> GetImageBytesAsync(string imageUrl, CancellationToken ct = default);
}
