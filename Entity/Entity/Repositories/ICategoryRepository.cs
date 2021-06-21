using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Repositories
{
    public interface ICategoryRepository
    {
        Task<Category> CreateCategory(Category category);
        Task<List<Category>> GetCategories(string Id);
        Task<Category> GetCategory(int Id);
        Task<Category> GetCategory(string Name);
        Task UpdateCategory(Category category);
        Task DeleteCategory(Category category);
    }
}
