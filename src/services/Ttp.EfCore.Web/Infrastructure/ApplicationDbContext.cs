using System.Threading;
using System.Threading.Tasks;
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

        public DbSet<TrackingActivity> TrackingActivities { get; set; }

        public async Task<int> ExecuteSqlRaw(
            string sqlRaw, string[] parameters,
            CancellationToken cancellationToken)
        {
            return await Database.ExecuteSqlRawAsync(sqlRaw, parameters, cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
