using Entity;
using Entity.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;

namespace Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ReadLaterDataContext _dbContext;

        public CategoryRepository(ReadLaterDataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public async Task<Category> CreateCategory(Category category)
        {
            try
            {
                _dbContext.Add(category);
                await _dbContext.SaveChangesAsync();
                return category;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public async Task DeleteCategory(Category category)
        {
            try
            {
                _dbContext.Remove(category);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<Category>> GetCategories(string Id)
        {
            try
            {
                return await _dbContext.Categories.Where(x => x.UserId == Id).ToListAsync();
            } 
            catch(Exception)
            {
                throw;
            }
        }

        public async Task<Category> GetCategory(int Id)
        {
            try
            {
                return await _dbContext.FindAsync<Category>(Id);
            }
            catch(Exception)
            {
                throw;
            }
        }

        public async Task<Category> GetCategory(string Name)
        {
            try
            {
                return await _dbContext.FindAsync<Category>(Name);
            } 
            catch(Exception)
            {
                throw;
            }
        }

        public async Task UpdateCategory(Category category)
        {
            try
            {
                _dbContext.Update(category);
                await _dbContext.SaveChangesAsync();
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
