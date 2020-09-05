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
                    Ohrmarkennummer = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Geschlecht = table.Column<string>(nullable: true),
                    Geburtsdatum = table.Column<string>(nullable: true),
                    Alter = table.Column<int>(nullable: false),
                    Geburtsbetrieb = table.Column<int>(nullable: true),
                    Rasse = table.Column<string>(nullable: true),
                    Labelmeldung = table.Column<string>(nullable: true),
                    Erstkalbung = table.Column<string>(nullable: true),
                    LetzteAbkalbung = table.Column<string>(nullable: true),
                    Nutzungsart = table.Column<string>(nullable: true),
                    Gltigab = table.Column<string>(nullable: true),
                    VorherigeNutzungsart = table.Column<string>(nullable: true),
                    Zugangsdatum = table.Column<string>(nullable: true),
                    Herkunftsbetrieb = table.Column<string>(nullable: true),
                    Abgangsdatum = table.Column<string>(nullable: true),
                    Folgebetrieb = table.Column<string>(nullable: true),
                    Tiergeschichte = table.Column<string>(nullable: true),
                    LetzteGanzjahrestierhaltung = table.Column<string>(nullable: true),
                    BVDStatus = table.Column<string>(nullable: true),
                    BLZ_Status = table.Column<string>(nullable: true),
                    Mutter_OM = table.Column<string>(nullable: true),
                    Mutter_Name = table.Column<string>(nullable: true),
                    Mutter_Rasse = table.Column<string>(nullable: true),
                    Vater_OM = table.Column<string>(nullable: true),
                    Vater_Name = table.Column<string>(nullable: true),
                    Vater_Rasse = table.Column<string>(nullable: true),
                    Todesdatum = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TvdModel", x => x.Ohrmarkennummer);
                });

            migrationBuilder.CreateTable(
                name: "GveModel",
                columns: table => new
                {
                    GveId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    TvdOhrmarkennummer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GveModel", x => x.GveId);
                    table.ForeignKey(
                        name: "FK_GveModel_TvdModel_TvdOhrmarkennummer",
                        column: x => x.TvdOhrmarkennummer,
                        principalTable: "TvdModel",
                        principalColumn: "Ohrmarkennummer",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GveLocationModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GveId = table.Column<string>(nullable: true),
                    Latitude = table.Column<float>(nullable: false),
                    Longitude = table.Column<float>(nullable: false),
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
                name: "IX_GveModel_TvdOhrmarkennummer",
                table: "GveModel",
                column: "TvdOhrmarkennummer");
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
