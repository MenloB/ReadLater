using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadLater5.Models
{
    public class CategoriesBookmarksViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Bookmark> Bookmarks { get; set; }
    }
}
