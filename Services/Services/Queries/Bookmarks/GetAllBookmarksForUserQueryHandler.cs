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
    public class GetAllBookmarksForUserQueryHandler : IRequestHandler<GetAllBookmarksForUserQuery, List<Bookmark>>
    {
        private readonly IBookmarkRepository _repository;

        public GetAllBookmarksForUserQueryHandler(IBookmarkRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<Bookmark>> Handle(GetAllBookmarksForUserQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllBookmarksForUser(request.UserId);
        }
    }
}
