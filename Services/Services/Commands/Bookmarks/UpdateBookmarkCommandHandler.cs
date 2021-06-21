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
    public class UpdateBookmarkCommandHandler : IRequestHandler<UpdateBookmarkCommand, Unit>
    {
        private readonly IBookmarkRepository _repository;

        public UpdateBookmarkCommandHandler(IBookmarkRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateBookmarkCommand request, CancellationToken cancellationToken)
        {
            await _repository.UpdateBookmark(request.BookmarkToUpdate);
            return new Unit();
        }
    }
}
