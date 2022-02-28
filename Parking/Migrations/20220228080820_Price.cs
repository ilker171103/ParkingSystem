using Microsoft.EntityFrameworkCore.Migrations;

namespace Parking.Migrations
{
    public partial class Price : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price12h",
                table: "Parkings",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Price24h",
                table: "Parkings",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price12h",
                table: "Parkings");

            migrationBuilder.DropColumn(
                name: "Price24h",
                table: "Parkings");
        }
    }
}
