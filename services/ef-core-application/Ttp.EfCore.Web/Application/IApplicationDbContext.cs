using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ttp.EfCore.Web.Domain.Entities;

namespace Ttp.EfCore.Web.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Product> Products { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
