using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Ttp.EfCore.Web.Application.Interfaces;
using Ttp.EfCore.Web.Application.Models;

namespace Ttp.EfCore.Web.Application.Queries
{
    public class TrackingActivityQueryHandler : IRequestHandler<TrackingActivityQuery, List<TrackingActivityModel>>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public TrackingActivityQueryHandler(IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<TrackingActivityModel>> Handle(TrackingActivityQuery request, CancellationToken cancellationToken)
        {
            return await _applicationDbContext.TrackingActivities.Where(p => p.UserId == request.UserId).Select(p => new TrackingActivityModel(p)).ToListAsync(cancellationToken);
        }
    }
}
