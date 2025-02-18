using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class tablesnamechange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CachedLocations");

            migrationBuilder.CreateTable(
                name: "CachedAddress",
                columns: table => new
                {
                    CachedLocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CachedAdressID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CachedAddress", x => x.CachedLocationID);
                    table.ForeignKey(
                        name: "FK_CachedAddress_Address_CachedAdressID",
                        column: x => x.CachedAdressID,
                        principalTable: "Address",
                        principalColumn: "AdressID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CachedAddress_CachedAdressID",
                table: "CachedAddress",
                column: "CachedAdressID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CachedAddress");

            migrationBuilder.CreateTable(
                name: "CachedLocations",
                columns: table => new
                {
                    CachedLocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CachedAdressID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CachedLocations", x => x.CachedLocationID);
                    table.ForeignKey(
                        name: "FK_CachedLocations_Address_CachedAdressID",
                        column: x => x.CachedAdressID,
                        principalTable: "Address",
                        principalColumn: "AdressID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CachedLocations_CachedAdressID",
                table: "CachedLocations",
                column: "CachedAdressID");
        }
    }
}
