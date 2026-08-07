namespace Yukari.Core.Models;

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
