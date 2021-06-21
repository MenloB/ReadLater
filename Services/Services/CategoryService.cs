using Entity;
using MediatR;
using Services.Commands.Categories;
using Services.Queries.Categories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    public class CategoryService : ICategoryService
    {
        private IMediator _mediator;
        public CategoryService(IMediator mediator) 
        {
            _mediator = mediator;
        }

        public async Task<Category> CreateCategory(Category category)
        {
            var command = new CreateCategoryCommand(category);
            var result = await _mediator.Send(command);
            return result;
        }

        public async Task UpdateCategory(Category category)
        {
            var command = new UpdateCategoryCommand(category);
            var result = await _mediator.Send(command);
        }

        public async Task<List<Category>> GetCategoriesForUser(string Id)
        {
            var query = new GetCategoriesForUserQuery(Id);
            var result =  await _mediator.Send(query);
            return result;
        }

        public async Task<Category> GetCategory(int Id)
        {
            var query = new GetCategoryByIdQuery(Id);
            var result = await _mediator.Send(query);
            return result;
        }

        public async Task<Category> GetCategory(string Name)
        {
            var query = new GetCategoryByNameQuery(Name);
            var result = await _mediator.Send(query);
            return result;
        }

        public async Task DeleteCategory(Category category)
        {
            var command = new DeleteCategoryCommand(category);
            await _mediator.Send(command);
        }
    }
}
