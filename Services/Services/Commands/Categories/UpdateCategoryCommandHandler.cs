using Entity.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Commands.Categories
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, Unit>
    {
        private readonly ICategoryRepository _repository;

        public UpdateCategoryCommandHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            await _repository.UpdateCategory(request.CategoryToUpdate);
            return new Unit();
        }
    }
}
