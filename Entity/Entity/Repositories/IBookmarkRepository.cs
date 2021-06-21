using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repositories
{
    public interface IBookmarkRepository
    {
        Task<Bookmark> CreateBookmark(Bookmark bookmark);
        Task<List<Bookmark>> GetAllBookmarksForCategory(int categoryId);
        Task<List<Bookmark>> GetAllBookmarks();
        Task UpdateBookmark(Bookmark bookmark);
        Task DeleteBookmark(int id);
        Task DeleteBookmark(Bookmark bookmark);
        Task<Bookmark> GetBookmarkById(int bookmarkId);
        Task<List<Bookmark>> GetAllBookmarksForUser(string userId);
    }
}
