using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_VAS.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GveLocationModel",
                columns: table => new
                {
                    GveId = table.Column<string>(nullable: false),
                    Coordinates = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GveLocationModel", x => x.GveId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GveLocationModel");
        }
    }
}
