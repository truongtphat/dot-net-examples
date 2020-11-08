using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ttp.EfCore.Web.Domain.Entities;

namespace Ttp.EfCore.Web.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Product> Products { get; set; }

        DbSet<TrackingActivity> TrackingActivities { get; set; }

        Task<int> ExecuteSqlRaw(
            string sqlRaw,
            string[] parameters,
            CancellationToken cancellationToken);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
