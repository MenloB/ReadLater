using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ICategoryService
    {
        Task<Category> CreateCategory(Category category);
        Task<List<Category>> GetCategoriesForUser(string Id);
        Task<Category> GetCategory(int Id);
        Task<Category> GetCategory(string Name);
        Task UpdateCategory(Category category);
        Task DeleteCategory(Category category);
    }
}
