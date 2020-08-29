using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ttp.EfCore.Web.Migrations
{
    public partial class AddUserTrackingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TrackingActivities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Total = table.Column<int>(nullable: false),
                    TrackingType = table.Column<string>(type: "varchar(50)", nullable: false),
                    TrackingAction = table.Column<string>(type: "varchar(50)", nullable: false, defaultValue: "View"),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackingActivities", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrackingActivities");
        }
    }
}
