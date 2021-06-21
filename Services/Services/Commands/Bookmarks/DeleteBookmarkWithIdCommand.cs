using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Commands.Bookmarks
{
    public class DeleteBookmarkWithIdCommand : IRequest
    {
        public int BookmarkId { get; }

        public DeleteBookmarkWithIdCommand(int bookmarkId)
        {
            BookmarkId = bookmarkId;
        }
    }
}
