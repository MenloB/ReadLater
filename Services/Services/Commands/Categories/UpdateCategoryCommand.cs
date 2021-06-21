using Entity;
using MediatR;

namespace Services.Commands.Categories
{
    public class UpdateCategoryCommand : IRequest<Unit>
    {
        public Category CategoryToUpdate { get; }

        public UpdateCategoryCommand(Category category)
        {
            CategoryToUpdate = category;
        }
    }
}
