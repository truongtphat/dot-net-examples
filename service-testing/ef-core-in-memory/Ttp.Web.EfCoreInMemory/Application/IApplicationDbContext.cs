using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ttp.Web.EfCoreInMemory.Domain.Entities;

namespace Ttp.Web.EfCoreInMemory.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Product> Products { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
