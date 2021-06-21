using Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Queries.Bookmarks
{
    public class GetAllBookmarksQuery : IRequest<List<Bookmark>>
    {
    }
}
