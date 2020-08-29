using System;
using Ttp.EfCore.Web.Domain.Entities;

namespace Ttp.EfCore.Web.Application.Models
{
    public class ProductModel
    {
        public ProductModel()
        {
        }

        public ProductModel(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            Quantity = product.Quantity;
            Description = product.Description;
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }
    }
}
