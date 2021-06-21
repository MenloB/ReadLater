using Entity;
using MediatR;

namespace Services.Queries.Categories
{
    public class GetCategoryByIdQuery : IRequest<Category>
    {
        public int Id { get; }

        public GetCategoryByIdQuery(int id)
        {
            Id = id;
        }
    }
}
