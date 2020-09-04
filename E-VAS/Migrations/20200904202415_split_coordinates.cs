using Microsoft.EntityFrameworkCore.Migrations;

namespace E_VAS.Migrations
{
    public partial class split_coordinates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Coordinates",
                table: "GveLocationModel");

            migrationBuilder.AddColumn<float>(
                name: "Latitude",
                table: "GveLocationModel",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Longitude",
                table: "GveLocationModel",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "GveLocationModel");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "GveLocationModel");

            migrationBuilder.AddColumn<string>(
                name: "Coordinates",
                table: "GveLocationModel",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
