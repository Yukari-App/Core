namespace Yukari.Core.Models;

public record Comic(
    string Id,
    string Source,
    string? ComicUrl,
    string? Slug,
    string Title,
    string? Author,
    string? Description,
    string[] Tags,
    int? Year,
    string? CoverImageUrl,
    string[] Langs
);
