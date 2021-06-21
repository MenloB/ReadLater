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
    public class GetBookmarkByIdQueryHandler : IRequestHandler<GetBookmarkByIdQuery, Bookmark>
    {
        private readonly IBookmarkRepository _repository;

        public GetBookmarkByIdQueryHandler(IBookmarkRepository repository)
        {
            _repository = repository;
        }

        public async Task<Bookmark> Handle(GetBookmarkByIdQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetBookmarkById(request.BookmarkId);
        }
    }
}
