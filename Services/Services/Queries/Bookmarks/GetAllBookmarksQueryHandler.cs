using Entity;
using Entity.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Queries.Bookmarks
{
    public class GetAllBookmarksQueryHandler : IRequestHandler<GetAllBookmarksQuery, List<Bookmark>>
    {
        private readonly IBookmarkRepository _repository;

        public GetAllBookmarksQueryHandler(IBookmarkRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Bookmark>> Handle(GetAllBookmarksQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllBookmarks();
        }
    }
}
