using Microsoft.EntityFrameworkCore;
using Ttp.Web.EfCoreInMemory.Application.Interfaces;
using Ttp.Web.EfCoreInMemory.Domain.Entities;

namespace Ttp.Web.EfCoreInMemory.Infrastructure
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
