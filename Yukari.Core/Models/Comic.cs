namespace Yukari.Core.Models;

/// <summary>
/// Represents a comic series and its metadata returned by a <see cref="Sources.IComicSource"/>.
/// </summary>
/// <param name="Id">The unique identifier of the comic within its source.</param>
/// <param name="ComicUrl">The canonical web URL of the comic on the source website, if available.</param>
/// <param name="Title">The display title of the comic.</param>
/// <param name="Author">The author or artist of the comic, if known.</param>
/// <param name="Description">The synopsis or description of the comic.</param>
/// <param name="Tags">The genres, themes, or tags associated with the comic.</param>
/// <param name="Year">The release or publication year of the comic, if known.</param>
/// <param name="CoverImageUrl">
/// The URL of the comic's cover image, which the host resolves by calling <see cref="Sources.IComicSource.GetImageBytesAsync"/>.
/// </param>
/// <param name="Langs">
/// The source-defined language keys (matching keys in <see cref="Sources.IComicSource.Languages"/>) in which chapters are available for this comic.
/// </param>
/// <param name="Status">The publication status of the comic.</param>
public record Comic(
    string Id,
    string? ComicUrl,
    string Title,
    string? Author,
    string? Description,
    string[] Tags,
    int? Year,
    string? CoverImageUrl,
    string[] Langs,
    ComicStatus Status = ComicStatus.Unknown
);
