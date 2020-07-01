using Ttp.Web.EfCoreInMemory.Domain.Entities;

namespace Ttp.Web.EfCoreInMemory.Application.Models
{
    public class ProductModel
    {
        public ProductModel()
        {
        }

        public ProductModel(Product product)
        {
            Name = product.Name;
            Quantity = product.Quantity;
            Description = product.Description;
        }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }
    }
}
