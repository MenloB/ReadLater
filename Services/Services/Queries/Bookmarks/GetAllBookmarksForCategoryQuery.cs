using Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Queries.Bookmarks
{
    public class GetAllBookmarksForCategoryQuery : IRequest<List<Bookmark>>
    {
        public int CategoryId { get; }

        public GetAllBookmarksForCategoryQuery(int id)
        {
            CategoryId = id;
        }
    }
}
