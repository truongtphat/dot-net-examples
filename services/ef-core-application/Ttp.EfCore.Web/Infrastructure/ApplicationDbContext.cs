using Microsoft.EntityFrameworkCore;
using Ttp.EfCore.Web.Application.Interfaces;
using Ttp.EfCore.Web.Domain.Entities;

namespace Ttp.EfCore.Web.Infrastructure
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
