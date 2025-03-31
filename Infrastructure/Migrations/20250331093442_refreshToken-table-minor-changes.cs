using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class refreshTokentableminorchanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RefreshToken_AspNetUsers_ApplicationUserId",
                table: "RefreshToken");

            migrationBuilder.DropIndex(
                name: "IX_RefreshToken_ApplicationUserId",
                table: "RefreshToken");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "RefreshToken");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "RefreshToken",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_UserID",
                table: "RefreshToken",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_RefreshToken_AspNetUsers_UserID",
                table: "RefreshToken",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RefreshToken_AspNetUsers_UserID",
                table: "RefreshToken");

            migrationBuilder.DropIndex(
                name: "IX_RefreshToken_UserID",
                table: "RefreshToken");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "RefreshToken",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "RefreshToken",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_ApplicationUserId",
                table: "RefreshToken",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RefreshToken_AspNetUsers_ApplicationUserId",
                table: "RefreshToken",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
