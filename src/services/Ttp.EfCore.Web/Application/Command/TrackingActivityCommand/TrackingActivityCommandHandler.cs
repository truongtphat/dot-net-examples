using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Ttp.EfCore.Web.Application.Interfaces;

namespace Ttp.EfCore.Web.Application.Command
{
    public class TrackingActivityCommandHandler : AsyncRequestHandler<TrackingActivityCommand>
    {
        private readonly IApplicationDbContext _applicationDbContext;

        public TrackingActivityCommandHandler(
            IApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        protected override async Task Handle(
            TrackingActivityCommand request, 
            CancellationToken cancellationToken)
        {
            var parameters = new[]
            {
                $"{request.UserId}",
                $"{request.TrackingAction}",
                $"{request.TrackingType}"
            };

            await _applicationDbContext.ExecuteSqlRaw(
                "AddOrUpdateTrackingActivity @p0,@p1,@p2",
                parameters,
                cancellationToken);
        }
    }
}
