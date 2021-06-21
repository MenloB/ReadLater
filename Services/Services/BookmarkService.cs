using Entity;
using MediatR;
using Services.Commands.Bookmarks;
using Services.Queries.Bookmarks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookmarkService : IBookmarkService
    {
        private readonly IMediator _mediator;

        public BookmarkService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task<Bookmark> CreateBookmark(Bookmark bookmark)
        {
            var command = new CreateBookmarkCommand(bookmark);
            return _mediator.Send(command);
        }

        public async Task DeleteBookmark(int id)
        {
            var command = new DeleteBookmarkWithIdCommand(id);
            await _mediator.Send(command);
        }

        public async Task DeleteBookmark(Bookmark bookmark)
        {
            //TODO: implement command and command handler

            var command = new DeleteBookmarkCommand(bookmark);
            await _mediator.Send(command);
        }

        public async Task<List<Bookmark>> GetAllBookmarks()
        {
            var query = new GetAllBookmarksQuery();
            return await _mediator.Send(query);
        }

        public async Task<List<Bookmark>> GetAllBookmarksForCategory(int categoryId)
        {
            var command = new GetAllBookmarksForCategoryQuery(categoryId);
            return await _mediator.Send(command);
        }

        public async Task<List<Bookmark>> GetAllBookmarksForUser(string userId)
        {
            var query = new GetAllBookmarksForUserQuery(userId);
            return await _mediator.Send(query);
        }

        public async Task<Bookmark> GetBookmarkById(int bookmarkId)
        {
            var query = new GetBookmarkByIdQuery(bookmarkId);
            return await _mediator.Send(query);
        }

        public async Task UpdateBookmark(Bookmark bookmark)
        {
            var command = new UpdateBookmarkCommand (bookmark);
            await _mediator.Send(command);
        }
    }
}
