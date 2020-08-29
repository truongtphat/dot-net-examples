using System;
using Ttp.EfCore.Web.Domain.ValueObjects;

namespace Ttp.EfCore.Web.Domain.Entities
{
    public class TrackingActivity : Entity
    {
        public int Total { get; set; }

        public TrackingType TrackingType { get; set; }

        public TrackingAction TrackingAction { get; set; }

        public Guid UserId { get; set; }
    }
}
