using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yukari.Core.Models
{
    public record Manga(
            string Id,
            string Source,
            string Slug,
            string Title,
            string Author,
            string Description,
            string[] Tags,
            int Year,
            string CoverImageUrl,
            string[] Langs
        );
}
