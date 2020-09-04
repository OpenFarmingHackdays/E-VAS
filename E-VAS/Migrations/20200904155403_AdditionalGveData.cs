using Microsoft.EntityFrameworkCore.Migrations;

namespace E_VAS.Migrations
{
    public partial class AdditionalGveData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TvdName",
                table: "TvdModel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "GveModel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TvdName",
                table: "TvdModel");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "GveModel");
        }
    }
}
