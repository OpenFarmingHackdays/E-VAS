using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_VAS.Migrations
{
    public partial class AddGvePlaceModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GvePlaceModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GvePlaceModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GvePlacePointModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Latitude = table.Column<float>(nullable: false),
                    Longitude = table.Column<float>(nullable: false),
                    GvePlaceModelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GvePlacePointModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GvePlacePointModel_GvePlaceModel_GvePlaceModelId",
                        column: x => x.GvePlaceModelId,
                        principalTable: "GvePlaceModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GvePlacePointModel_GvePlaceModelId",
                table: "GvePlacePointModel",
                column: "GvePlaceModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GvePlacePointModel");

            migrationBuilder.DropTable(
                name: "GvePlaceModel");
        }
    }
}
