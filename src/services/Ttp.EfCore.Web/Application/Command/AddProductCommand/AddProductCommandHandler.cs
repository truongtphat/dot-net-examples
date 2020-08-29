using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Ttp.EfCore.Web.Application.Interfaces;
using Ttp.EfCore.Web.Application.Models;
using Ttp.EfCore.Web.Domain.Entities;

namespace Ttp.EfCore.Web.Application.Command
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, ProductModel>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public AddProductCommandHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<ProductModel> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var model = new ProductModel
            {
                Name = request.Name,
                Description = request.Description,
                Quantity = request.Quantity
            };

            var product = new Product
            {
                Id = Guid.NewGuid()
            };

            ToEntity(model, product);

            await _applicationDbContext.Products.AddAsync(product, cancellationToken);
            await _applicationDbContext.SaveChangesAsync(cancellationToken);

            return model;
        }

        private void ToEntity(ProductModel model, Product product)
        {
            product.Name = model.Name;
            product.Description = model.Description;
            product.Quantity = model.Quantity;
        }
    }
}
