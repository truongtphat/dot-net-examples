using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ttp.EfCore.Web.Domain.Entities;
using Ttp.EfCore.Web.Domain.ValueObjects;

namespace Ttp.EfCore.Web.Infrastructure
{
    public class TrackingActivityConfiguration : BaseEntityConfiguration<TrackingActivity>
    {
        public override void Configure(EntityTypeBuilder<TrackingActivity> builder)
        {
            builder.Property(p => p.TrackingAction)
                .HasConversion(new EnumToStringConverter<TrackingAction>())
                .HasDefaultValue(TrackingAction.View)
                .HasColumnType("varchar(50)");

            builder.Property(p => p.TrackingType)
                .HasConversion(new EnumToStringConverter<TrackingType>())
                .HasColumnType("varchar(50)");
        }
    }
}
