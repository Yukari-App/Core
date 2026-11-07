namespace Yukari.Core.Models;

/// <summary>
/// Represents a single page of a comic chapter.
/// </summary>
/// <param name="Number">The 1-based page number indicating its reading order in the chapter.</param>
/// <param name="ImageUrl">
/// The URL of the page image, which the host resolves by calling <see cref="Sources.IComicSource.GetImageBytesAsync"/>.
/// </param>
public record ChapterPage(int Number, string ImageUrl);
