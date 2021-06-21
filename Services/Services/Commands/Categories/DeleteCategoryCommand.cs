using Entity;
using MediatR;

namespace Services.Commands.Categories
{
    public class DeleteCategoryCommand : IRequest
    {
        public Category CategoryToBeDeleted { get; }

        public DeleteCategoryCommand(Category category)
        {
            CategoryToBeDeleted = category;
        }
    }
}
