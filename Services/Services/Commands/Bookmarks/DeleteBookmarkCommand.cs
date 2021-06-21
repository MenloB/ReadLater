using Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Commands.Bookmarks
{
    public class DeleteBookmarkCommand : IRequest
    {
        public DeleteBookmarkCommand(Bookmark bookmark)
        {
            BookmarkToBeDeleted = bookmark;
        }

        public Bookmark BookmarkToBeDeleted { get; }
    }
}
