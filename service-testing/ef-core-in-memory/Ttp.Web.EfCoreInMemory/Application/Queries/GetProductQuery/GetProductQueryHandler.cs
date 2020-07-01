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
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, List<ProductModel>>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public GetProductQueryHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<ProductModel>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var products = await _applicationDbContext.Products.Select(p => new ProductModel(p)).ToListAsync(cancellationToken);
            return products;
        }
    }
}
