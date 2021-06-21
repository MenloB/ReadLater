using Entity;
using Entity.Repositories;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Services.Queries.Categories
{
    public class GetCategoriesQueryHandler : IRequestHandler<GetCategoriesForUserQuery, List<Category>>
    {
        private readonly ICategoryRepository _repository;

        public GetCategoriesQueryHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Category>> Handle(GetCategoriesForUserQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetCategories(request.UserId);
        }
    }
}
