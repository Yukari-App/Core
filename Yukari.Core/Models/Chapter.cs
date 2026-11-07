namespace Yukari.Core.Models;

/// <summary>
/// Represents a single chapter of a comic returned by a <see cref="Sources.IComicSource"/>.
/// </summary>
/// <param name="Id">The unique identifier of the chapter within its comic source.</param>
/// <param name="Title">The optional title of the chapter.</param>
/// <param name="Number">The chapter number (for example, <c>"1"</c> or <c>"12.5"</c>).</param>
/// <param name="Volume">The volume number or label the chapter belongs to, if any.</param>
/// <param name="Language">
/// The source-defined language key of the chapter (matching a key in <see cref="Sources.IComicSource.Languages"/>, such as <c>"en"</c> or <c>"pt-br"</c>).
/// </param>
/// <param name="Groups">The scanlation or publisher groups credited for the chapter.</param>
/// <param name="LastUpdate">The date when the chapter was published or last updated.</param>
/// <param name="Pages">The total number of pages in the chapter, if known ahead of time.</param>
public record Chapter(
    string Id,
    string? Title,
    string? Number,
    string? Volume,
    string? Language,
    string[] Groups,
    DateOnly? LastUpdate,
    int? Pages
);
