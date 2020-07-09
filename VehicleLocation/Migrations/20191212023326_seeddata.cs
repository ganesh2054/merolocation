using Microsoft.EntityFrameworkCore.Migrations;

namespace VehicleLocation.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "locations",
                columns: new[] { "Id", "IpAddress", "RouteName", "latitude", "longitude" },
                values: new object[] { 1, "111.119.43.77", "jaranku", 27.7581464, 85.301498 });

            migrationBuilder.InsertData(
                table: "vehicles",
                columns: new[] { "id", "IpAddress", "RouteName" },
                values: new object[] { 1, "111.119.43.77", "jaranku" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "vehicles",
                keyColumn: "id",
                keyValue: 1);
        }
    }
}
