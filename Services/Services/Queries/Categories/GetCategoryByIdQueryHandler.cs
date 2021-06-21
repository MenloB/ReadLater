using Entity;
using Entity.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Queries.Categories
{
    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQuery, Category>
    {
        private readonly ICategoryRepository _repository;

        public GetCategoryByIdQueryHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<Category> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetCategory(request.Id);

        }
    }
}
