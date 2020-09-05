using Microsoft.EntityFrameworkCore.Migrations;

namespace E_VAS.Migrations
{
    public partial class addLocationCat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LocationCategory",
                table: "GveLocationModel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationCategory",
                table: "GveLocationModel");
        }
    }
}
