using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Ttp.Web.EfCoreInMemory.Application.Interfaces;
using Ttp.Web.EfCoreInMemory.Application.Models;

namespace Ttp.Web.EfCoreInMemory.Application.Queries
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, List<ProductModel>>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public GetProductsQueryHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<ProductModel>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _applicationDbContext.Products.Select(p => new ProductModel(p)).ToListAsync(cancellationToken);
            return products;
        }
    }
}
