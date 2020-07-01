using System.Collections.Generic;
using MediatR;
using Ttp.Web.EfCoreInMemory.Application.Models;

namespace Ttp.Web.EfCoreInMemory.Application.Queries
{
    public class GetProductQuery : IRequest<List<ProductModel>>
    {
    }
}
