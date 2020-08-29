namespace Ttp.EfCore.Web.Domain.Entities
{
    public class Product : Entity
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }
    }
}
