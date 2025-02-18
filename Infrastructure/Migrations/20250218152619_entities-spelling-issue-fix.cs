using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class entitiesspellingissuefix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advert_Address_AdvertAdressID",
                table: "Advert");

            migrationBuilder.DropForeignKey(
                name: "FK_CachedAddress_Address_CachedAdressID",
                table: "CachedAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_Address_CompanyAdressID",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Address_UserAdressID",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_CachedAddress_CachedAdressID",
                table: "CachedAddress");

            migrationBuilder.RenameColumn(
                name: "UserAdressID",
                table: "User",
                newName: "UserAddressID");

            migrationBuilder.RenameIndex(
                name: "IX_User_UserAdressID",
                table: "User",
                newName: "IX_User_UserAddressID");

            migrationBuilder.RenameColumn(
                name: "CompanyAdressID",
                table: "Company",
                newName: "CompanyAddressID");

            migrationBuilder.RenameIndex(
                name: "IX_Company_CompanyAdressID",
                table: "Company",
                newName: "IX_Company_CompanyAddressID");

            migrationBuilder.RenameColumn(
                name: "CachedAdressID",
                table: "CachedAddress",
                newName: "AddressID");

            migrationBuilder.RenameColumn(
                name: "CachedLocationID",
                table: "CachedAddress",
                newName: "CachedAddressID");

            migrationBuilder.RenameColumn(
                name: "AdvertAdressID",
                table: "Advert",
                newName: "AdvertAddressID");

            migrationBuilder.RenameIndex(
                name: "IX_Advert_AdvertAdressID",
                table: "Advert",
                newName: "IX_Advert_AdvertAddressID");

            migrationBuilder.RenameColumn(
                name: "AdressID",
                table: "Address",
                newName: "AddressID");

            // ERROR GENERATING CODE
            /*
            migrationBuilder.AlterColumn<int>(
                name: "CachedAddressID",
                table: "CachedAddress",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");
            */

            migrationBuilder.AddForeignKey(
                name: "FK_Advert_Address_AdvertAddressID",
                table: "Advert",
                column: "AdvertAddressID",
                principalTable: "Address",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CachedAddress_Address_CachedAddressID",
                table: "CachedAddress",
                column: "CachedAddressID",
                principalTable: "Address",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Address_CompanyAddressID",
                table: "Company",
                column: "CompanyAddressID",
                principalTable: "Address",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Address_UserAddressID",
                table: "User",
                column: "UserAddressID",
                principalTable: "Address",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advert_Address_AdvertAddressID",
                table: "Advert");

            migrationBuilder.DropForeignKey(
                name: "FK_CachedAddress_Address_CachedAddressID",
                table: "CachedAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_Address_CompanyAddressID",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Address_UserAddressID",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "UserAddressID",
                table: "User",
                newName: "UserAdressID");

            migrationBuilder.RenameIndex(
                name: "IX_User_UserAddressID",
                table: "User",
                newName: "IX_User_UserAdressID");

            migrationBuilder.RenameColumn(
                name: "CompanyAddressID",
                table: "Company",
                newName: "CompanyAdressID");

            migrationBuilder.RenameIndex(
                name: "IX_Company_CompanyAddressID",
                table: "Company",
                newName: "IX_Company_CompanyAdressID");

            migrationBuilder.RenameColumn(
                name: "AddressID",
                table: "CachedAddress",
                newName: "CachedAdressID");

            migrationBuilder.RenameColumn(
                name: "CachedAddressID",
                table: "CachedAddress",
                newName: "CachedLocationID");

            migrationBuilder.RenameColumn(
                name: "AdvertAddressID",
                table: "Advert",
                newName: "AdvertAdressID");

            migrationBuilder.RenameIndex(
                name: "IX_Advert_AdvertAddressID",
                table: "Advert",
                newName: "IX_Advert_AdvertAdressID");

            migrationBuilder.RenameColumn(
                name: "AddressID",
                table: "Address",
                newName: "AdressID");

            migrationBuilder.AlterColumn<int>(
                name: "CachedLocationID",
                table: "CachedAddress",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_CachedAddress_CachedAdressID",
                table: "CachedAddress",
                column: "CachedAdressID");

            migrationBuilder.AddForeignKey(
                name: "FK_Advert_Address_AdvertAdressID",
                table: "Advert",
                column: "AdvertAdressID",
                principalTable: "Address",
                principalColumn: "AdressID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CachedAddress_Address_CachedAdressID",
                table: "CachedAddress",
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
    }
}
