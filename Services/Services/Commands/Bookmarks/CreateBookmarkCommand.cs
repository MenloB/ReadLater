using Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Commands.Bookmarks
{
    public class CreateBookmarkCommand : IRequest<Bookmark>
    {
        public Bookmark BookmarkToCreate { get; }

        public CreateBookmarkCommand(Bookmark bookmark)
        {
            BookmarkToCreate = bookmark;
        }
    }
}
