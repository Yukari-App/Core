namespace Yukari.Core.Models
{
    public record Manga(
            string Id,
            string Source,
            string Slug,
            string Title,
            string? Author,
            string? Description,
            string[] Tags,
            int? Year,
            string CoverImageUrl,
            string[] Langs
        );
}
