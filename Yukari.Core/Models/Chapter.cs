namespace Yukari.Core.Models
{
    public record Chapter(
            string Id,
            string Source,
            string? Title,
            string ChapterUrl,
            int Number,
            string? CoverImageUrl,
            string? Volume,
            string Language,
            string? Groups,
            DateOnly LastUpdate,
            int PagesNumber
        );
}
