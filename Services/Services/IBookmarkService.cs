using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IBookmarkService
    {
        Task<Bookmark> CreateBookmark(Bookmark bookmark);
        Task DeleteBookmark(int id);
        Task DeleteBookmark(Bookmark bookmark);
        Task<List<Bookmark>> GetAllBookmarks();
        Task<List<Bookmark>> GetAllBookmarksForCategory(int categoryId);
        Task UpdateBookmark(Bookmark bookmark);
        Task<Bookmark> GetBookmarkById(int bookmarkId);
        Task<List<Bookmark>> GetAllBookmarksForUser(string userId);
    }
}
