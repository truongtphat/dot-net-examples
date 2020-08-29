using Microsoft.EntityFrameworkCore.Migrations;

namespace Ttp.EfCore.Web.Migrations
{
    public partial class CreateTrackingStoredProcedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE PROCEDURE AddOrUpdateTrackingActivity
                  @userId uniqueidentifier,
                  @trackingAction varchar(50),
                  @trackingType varchar(50)
                AS
                BEGIN
	                IF EXISTS (SELECT 1 FROM TrackingActivities WHERE [UserId] = @userId and [TrackingAction] = @trackingAction and [TrackingType] = @trackingType)
		                UPDATE TrackingActivities
		                SET Total += 1
		                WHERE [UserId] = @userId and [TrackingAction] = @trackingAction and [TrackingType] = @trackingType;
	                ELSE
		                INSERT INTO TrackingActivities VALUES(NEWID(),1,@trackingType,@trackingAction,@userId)
                END;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROC AddOrUpdateTrackingActivity");
        }
    }
}
