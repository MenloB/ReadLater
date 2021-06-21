using Entity;
using MediatR;
using System.Collections.Generic;

namespace Services.Queries.Categories
{
    public class GetCategoriesForUserQuery : IRequest<List<Category>>
    {
        public string UserId { get; }

        public GetCategoriesForUserQuery(string Id)
        {
            UserId = Id;
        }
    }
}
