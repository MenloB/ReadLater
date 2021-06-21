using Entity;
using Entity.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class BookmarkRepository : IBookmarkRepository
    {
        private readonly ReadLaterDataContext _dbContext;

        public BookmarkRepository(ReadLaterDataContext context)
        {
            _dbContext = context;
        }

        public async Task<Bookmark> CreateBookmark(Bookmark bookmark)
        {
            try
            {
                _dbContext.Add(bookmark);
                await _dbContext.SaveChangesAsync();
                return bookmark;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task DeleteBookmark(int id)
        {
            try
            {
                var bookmark = await _dbContext.FindAsync<Bookmark>(id);
                _dbContext.Remove(bookmark);
                await _dbContext.SaveChangesAsync();
            } 
            catch(Exception)
            {
                throw;
            }
        }

        public async Task DeleteBookmark(Bookmark bookmark)
        {
            try
            {
                _dbContext.Remove(bookmark);
                await _dbContext.SaveChangesAsync();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public async Task<List<Bookmark>> GetAllBookmarks()
        {
            try
            {
                return await _dbContext.Bookmark.ToListAsync();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public async Task<List<Bookmark>> GetAllBookmarksForCategory(int categoryId)
        {
            try
            {
                return await _dbContext.Bookmark.Where(x => x.CategoryId == categoryId).ToListAsync();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public async Task<List<Bookmark>> GetAllBookmarksForUser(string userId)
        {
            try
            {
                return await _dbContext.Bookmark.Where(x => x.UserId == userId).ToListAsync();
            } catch(Exception)
            {
                throw;
            }
        }

        public async Task<Bookmark> GetBookmarkById(int bookmarkId)
        {
            try
            {
                return await _dbContext.Bookmark.Where(x => x.ID == bookmarkId).FirstOrDefaultAsync();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public async Task UpdateBookmark(Bookmark bookmark)
        {
            try
            {
                _dbContext.Update(bookmark);
                await _dbContext.SaveChangesAsync();
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
