using Entity;
using MediatR;

namespace Services.Commands.Categories
{
    public class CreateCategoryCommand : IRequest<Category>
    {
        public Category CategoryToCreate { get; }

        public CreateCategoryCommand(Category category)
        {
            CategoryToCreate = category;
        }
    }
}
