using System;
using System.Threading.Tasks;
using MediatR;
using Ttp.EfCore.Web.Domain.ValueObjects;

namespace Ttp.EfCore.Web.Application.Command
{
    public class TrackingActivityCommand : IRequest
    {
        public Guid UserId { get; set; }

        public TrackingType TrackingType { get; set; }

        public TrackingAction TrackingAction { get; set; }
    }
}
