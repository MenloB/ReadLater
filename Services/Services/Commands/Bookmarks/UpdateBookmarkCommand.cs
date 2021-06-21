using Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Commands.Bookmarks
{
    public class UpdateBookmarkCommand : IRequest
    {
        public Bookmark BookmarkToUpdate { get; }

        public UpdateBookmarkCommand(Bookmark bookmark)
        {
            BookmarkToUpdate = bookmark;
        }
    }
}
