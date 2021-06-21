using Entity;
using MediatR;

namespace Services.Queries.Categories
{
    public class GetCategoryByNameQuery : IRequest<Category>
    {
        public string Name { get; }

        public GetCategoryByNameQuery(string name)
        {
            Name = name;
        }
    }
}
