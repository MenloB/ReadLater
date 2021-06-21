using Entity;
using Entity.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Commands.Categories
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, Category>
    {
        private readonly ICategoryRepository _repository;

        public CreateCategoryCommandHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<Category> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            return await _repository.CreateCategory(request.CategoryToCreate);
        }
    }
}
