using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Ttp.EfCore.Web.Application.Interfaces;
using Ttp.EfCore.Web.Application.Models;

namespace Ttp.EfCore.Web.Application.Queries
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
