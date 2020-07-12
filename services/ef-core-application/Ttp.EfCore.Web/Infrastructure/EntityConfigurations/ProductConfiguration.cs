using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ttp.EfCore.Web.Domain.Entities;

namespace Ttp.EfCore.Web.Infrastructure
{
    public class ProductConfiguration : BaseEntityConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Name)
                .HasColumnType("varchar(200)");

            builder.Property(p => p.Description)
                .HasColumnType("varchar(5000)");
        }
    }
}
