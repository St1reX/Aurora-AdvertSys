using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class advertExposuresdedicatedtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExposuresAmount",
                table: "Advert");

            migrationBuilder.CreateTable(
                name: "AdvertExposures",
                columns: table => new
                {
                    AdvertExposuresID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExposureAmount = table.Column<int>(type: "int", nullable: false),
                    ExposureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdvertID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertExposures", x => x.AdvertExposuresID);
                    table.ForeignKey(
                        name: "FK_AdvertExposures_Advert_AdvertID",
                        column: x => x.AdvertID,
                        principalTable: "Advert",
                        principalColumn: "AdvertID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdvertExposures_AdvertID",
                table: "AdvertExposures",
                column: "AdvertID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvertExposures");

            migrationBuilder.AddColumn<int>(
                name: "ExposuresAmount",
                table: "Advert",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
