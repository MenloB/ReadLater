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
    public class GetAllBookmarksForCategoryQueryHandler : IRequestHandler<GetAllBookmarksForCategoryQuery, List<Bookmark>>
    {
        private readonly IBookmarkRepository _repository;

        public GetAllBookmarksForCategoryQueryHandler(IBookmarkRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Bookmark>> Handle(GetAllBookmarksForCategoryQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllBookmarksForCategory(request.CategoryId);
        }
    }
}
