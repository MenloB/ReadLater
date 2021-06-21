using Entity.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Commands.Bookmarks
{
    public class DeleteBookmarkWithIdCommandHandler : IRequestHandler<DeleteBookmarkWithIdCommand, Unit>
    {
        private readonly IBookmarkRepository _repository;

        public DeleteBookmarkWithIdCommandHandler(IBookmarkRepository repository)
        {
            _repository = repository;
        }
        public async Task<Unit> Handle(DeleteBookmarkWithIdCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteBookmark(request.BookmarkId);
            return new Unit();
        }
    }
}
