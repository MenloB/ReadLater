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
    public class DeleteBookmarkCommandHandler : IRequestHandler<DeleteBookmarkCommand, Unit>
    {
        private readonly IBookmarkRepository _repository;

        public DeleteBookmarkCommandHandler(IBookmarkRepository repository)
        {
            _repository = repository;
        }
        public async Task<Unit> Handle(DeleteBookmarkCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteBookmark(request.BookmarkToBeDeleted);
            return new Unit();
        }
    }
}
