using Microsoft.EntityFrameworkCore;
using Ttp.Web.EfCoreInMemory.Domain.Entities;

namespace Ttp.Web.EfCoreInMemory.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
