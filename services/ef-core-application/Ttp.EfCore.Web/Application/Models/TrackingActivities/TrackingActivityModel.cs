using System;
using Ttp.EfCore.Web.Domain.Entities;
using Ttp.EfCore.Web.Domain.ValueObjects;

namespace Ttp.EfCore.Web.Application.Models
{
    public class TrackingActivityModel
    {
        public TrackingActivityModel(TrackingActivity trackingActivity)
        {
            UserId = trackingActivity.UserId;
            TrackingAction = trackingActivity.TrackingAction;
            TrackingType = trackingActivity.TrackingType;
            Total = trackingActivity.Total;
        }

        public Guid UserId { get; set; }

        public TrackingAction TrackingAction { get; set; }

        public TrackingType TrackingType { get; set; }

        public int Total { get; set; }
    }
}
