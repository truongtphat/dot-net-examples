using System.Collections.Generic;
using MediatR;
using Ttp.EfCore.Web.Application.Models;

namespace Ttp.EfCore.Web.Application.Queries
{
    public class GetProductsQuery : IRequest<List<ProductModel>>
    {
    }
}
