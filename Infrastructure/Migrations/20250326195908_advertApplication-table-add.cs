using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class advertApplicationtableadd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Advert",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExposuresAmount",
                table: "Advert",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Advert",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Address",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AdvertApplication",
                columns: table => new
                {
                    AdvertApplicationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvertID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ApplicationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    IsRejected = table.Column<bool>(type: "bit", nullable: false),
                    IsPending = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertApplication", x => x.AdvertApplicationID);
                    table.ForeignKey(
                        name: "FK_AdvertApplication_Advert_AdvertID",
                        column: x => x.AdvertID,
                        principalTable: "Advert",
                        principalColumn: "AdvertID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdvertApplication_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Advert_ApplicationUserId",
                table: "Advert",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Advert_UserID",
                table: "Advert",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertApplication_AdvertID",
                table: "AdvertApplication",
                column: "AdvertID");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertApplication_UserID",
                table: "AdvertApplication",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Advert_AspNetUsers_ApplicationUserId",
                table: "Advert",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Advert_AspNetUsers_UserID",
                table: "Advert",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Advert_AspNetUsers_ApplicationUserId",
                table: "Advert");

            migrationBuilder.DropForeignKey(
                name: "FK_Advert_AspNetUsers_UserID",
                table: "Advert");

            migrationBuilder.DropTable(
                name: "AdvertApplication");

            migrationBuilder.DropIndex(
                name: "IX_Advert_ApplicationUserId",
                table: "Advert");

            migrationBuilder.DropIndex(
                name: "IX_Advert_UserID",
                table: "Advert");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Advert");

            migrationBuilder.DropColumn(
                name: "ExposuresAmount",
                table: "Advert");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Advert");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Address",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
