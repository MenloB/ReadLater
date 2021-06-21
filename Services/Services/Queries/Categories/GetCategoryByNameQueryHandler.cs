using Entity;
using Entity.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Queries.Categories
{
    public class GetCategoryByNameQueryHandler : IRequestHandler<GetCategoryByNameQuery, Category>
    {
        private readonly ICategoryRepository _repository;

        public GetCategoryByNameQueryHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<Category> Handle(GetCategoryByNameQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetCategory(request.Name);
        }
    }
}
