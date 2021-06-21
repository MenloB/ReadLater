using Entity.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Commands.Categories
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand>
    {
        private readonly ICategoryRepository _repository;

        public DeleteCategoryCommandHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteCategory(request.CategoryToBeDeleted);
            return new Unit();
                
        }
    }
}
