using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddressUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advert_Adress_AdvertAdressID",
                table: "Advert");

            migrationBuilder.DropForeignKey(
                name: "FK_AdvertFilterLocationCached_Adress_CachedAdressID",
                table: "AdvertFilterLocationCached");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_Adress_CompanyAdressID",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Adress_UserAdressID",
                table: "User");

            migrationBuilder.DropTable(
                name: "Adress");

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AdressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreetNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AdressID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Advert_Address_AdvertAdressID",
                table: "Advert",
                column: "AdvertAdressID",
                principalTable: "Address",
                principalColumn: "AdressID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AdvertFilterLocationCached_Address_CachedAdressID",
                table: "AdvertFilterLocationCached",
                column: "CachedAdressID",
                principalTable: "Address",
                principalColumn: "AdressID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Address_CompanyAdressID",
                table: "Company",
                column: "CompanyAdressID",
                principalTable: "Address",
                principalColumn: "AdressID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Address_UserAdressID",
                table: "User",
                column: "UserAdressID",
                principalTable: "Address",
                principalColumn: "AdressID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advert_Address_AdvertAdressID",
                table: "Advert");

            migrationBuilder.DropForeignKey(
                name: "FK_AdvertFilterLocationCached_Address_CachedAdressID",
                table: "AdvertFilterLocationCached");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_Address_CompanyAdressID",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Address_UserAdressID",
                table: "User");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.CreateTable(
                name: "Adress",
                columns: table => new
                {
                    AdressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adress", x => x.AdressID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Advert_Adress_AdvertAdressID",
                table: "Advert",
                column: "AdvertAdressID",
                principalTable: "Adress",
                principalColumn: "AdressID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AdvertFilterLocationCached_Adress_CachedAdressID",
                table: "AdvertFilterLocationCached",
                column: "CachedAdressID",
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
    }
}
