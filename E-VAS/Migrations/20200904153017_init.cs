using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_VAS.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TvdModel",
                columns: table => new
                {
                    TvdId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TvdModel", x => x.TvdId);
                });

            migrationBuilder.CreateTable(
                name: "GveModel",
                columns: table => new
                {
                    GveId = table.Column<string>(nullable: false),
                    TvdId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GveModel", x => x.GveId);
                    table.ForeignKey(
                        name: "FK_GveModel_TvdModel_TvdId",
                        column: x => x.TvdId,
                        principalTable: "TvdModel",
                        principalColumn: "TvdId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GveLocationModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GveId = table.Column<string>(nullable: true),
                    Coordinates = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GveLocationModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GveLocationModel_GveModel_GveId",
                        column: x => x.GveId,
                        principalTable: "GveModel",
                        principalColumn: "GveId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GveLocationModel_GveId",
                table: "GveLocationModel",
                column: "GveId");

            migrationBuilder.CreateIndex(
                name: "IX_GveModel_TvdId",
                table: "GveModel",
                column: "TvdId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GveLocationModel");

            migrationBuilder.DropTable(
                name: "GveModel");

            migrationBuilder.DropTable(
                name: "TvdModel");
        }
    }
}
