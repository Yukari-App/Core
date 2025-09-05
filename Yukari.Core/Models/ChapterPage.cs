using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yukari.Core.Models
{
    public record ChapterPage(
            string Id,
            string Source,
            int PageNumber,
            string ImageUrl
        );
}
