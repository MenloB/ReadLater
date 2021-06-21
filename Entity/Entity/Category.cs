using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Category
    {
        [Key]
        public int ID { get; set; }

        [StringLength(maximumLength: 50)]
        public string Name { get; set; }
        public virtual ICollection<Bookmark> Bookmarks { get; set; }
        [Column("BookmarkingUserId")]
        public string UserId { get; set; }
    }
}
