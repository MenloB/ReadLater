using Entity;
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
    public class CreateBookmarkCommandHandler : IRequestHandler<CreateBookmarkCommand, Bookmark>
    {
        private readonly IBookmarkRepository _repository;

        public CreateBookmarkCommandHandler(IBookmarkRepository repository)
        {
            _repository = repository;
        }

        public async Task<Bookmark> Handle(CreateBookmarkCommand request, CancellationToken cancellationToken)
        {
            return await _repository.CreateBookmark(request.BookmarkToCreate);
        }
    }
}
