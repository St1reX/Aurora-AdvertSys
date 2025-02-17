using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SepareatedAdressTableUsedInManyTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvertFilterLocationQueryCache");

            migrationBuilder.DropTable(
                name: "CompanyAdress");

            migrationBuilder.DropTable(
                name: "UserAdress");

            migrationBuilder.AddColumn<int>(
                name: "UserAdressID",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyAdressID",
                table: "Company",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AdvertAdressID",
                table: "Advert",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Adress",
                columns: table => new
                {
                    AdressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreetNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adress", x => x.AdressID);
                });

            migrationBuilder.CreateTable(
                name: "AdvertFilterLocationCached",
                columns: table => new
                {
                    CachedLocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CachedAdressID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertFilterLocationCached", x => x.CachedLocationID);
                    table.ForeignKey(
                        name: "FK_AdvertFilterLocationCached_Adress_CachedAdressID",
                        column: x => x.CachedAdressID,
                        principalTable: "Adress",
                        principalColumn: "AdressID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_UserAdressID",
                table: "User",
                column: "UserAdressID");

            migrationBuilder.CreateIndex(
                name: "IX_Company_CompanyAdressID",
                table: "Company",
                column: "CompanyAdressID");

            migrationBuilder.CreateIndex(
                name: "IX_Advert_AdvertAdressID",
                table: "Advert",
                column: "AdvertAdressID");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertFilterLocationCached_CachedAdressID",
                table: "AdvertFilterLocationCached",
                column: "CachedAdressID");

            migrationBuilder.AddForeignKey(
                name: "FK_Advert_Adress_AdvertAdressID",
                table: "Advert",
                column: "AdvertAdressID",
                principalTable: "Adress",
                principalColumn: "AdressID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Adress_CompanyAdressID",
                table: "Company",
                column: "CompanyAdressID",
                principalTable: "Adress",
                principalColumn: "AdressID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Adress_UserAdressID",
                table: "User",
                column: "UserAdressID",
                principalTable: "Adress",
                principalColumn: "AdressID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advert_Adress_AdvertAdressID",
                table: "Advert");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_Adress_CompanyAdressID",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Adress_UserAdressID",
                table: "User");

            migrationBuilder.DropTable(
                name: "AdvertFilterLocationCached");

            migrationBuilder.DropTable(
                name: "Adress");

            migrationBuilder.DropIndex(
                name: "IX_User_UserAdressID",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Company_CompanyAdressID",
                table: "Company");

            migrationBuilder.DropIndex(
                name: "IX_Advert_AdvertAdressID",
                table: "Advert");

            migrationBuilder.DropColumn(
                name: "UserAdressID",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CompanyAdressID",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "AdvertAdressID",
                table: "Advert");

            migrationBuilder.CreateTable(
                name: "AdvertFilterLocationQueryCache",
                columns: table => new
                {
                    LocationCacheID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertFilterLocationQueryCache", x => x.LocationCacheID);
                });

            migrationBuilder.CreateTable(
                name: "CompanyAdress",
                columns: table => new
                {
                    CompanyAdressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StreetNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyAdress", x => x.CompanyAdressID);
                    table.ForeignKey(
                        name: "FK_CompanyAdress_Company_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Company",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAdress",
                columns: table => new
                {
                    UserAdressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Region = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StreetNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAdress", x => x.UserAdressID);
                    table.ForeignKey(
                        name: "FK_UserAdress_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyAdress_CompanyID",
                table: "CompanyAdress",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_UserAdress_UserID",
                table: "UserAdress",
                column: "UserID");
        }
    }
}
