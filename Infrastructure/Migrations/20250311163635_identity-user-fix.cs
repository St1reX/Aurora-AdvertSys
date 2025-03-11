using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class identityuserfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_AspNetUsers_ApplicationUserId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_User_UserID",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Education_AspNetUsers_ApplicationUserId",
                table: "Education");

            migrationBuilder.DropForeignKey(
                name: "FK_Education_User_UserID",
                table: "Education");

            migrationBuilder.DropForeignKey(
                name: "FK_Experience_AspNetUsers_ApplicationUserId",
                table: "Experience");

            migrationBuilder.DropForeignKey(
                name: "FK_Experience_User_UserID",
                table: "Experience");

            migrationBuilder.DropForeignKey(
                name: "FK_Link_AspNetUsers_ApplicationUserId",
                table: "Link");

            migrationBuilder.DropForeignKey(
                name: "FK_Link_User_UserID",
                table: "Link");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLanguage_AspNetUsers_ApplicationUserId",
                table: "UserLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLanguage_User_UserID",
                table: "UserLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSkill_AspNetUsers_ApplicationUserId",
                table: "UserSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSkill_User_UserID",
                table: "UserSkill");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropIndex(
                name: "IX_UserSkill_ApplicationUserId",
                table: "UserSkill");

            migrationBuilder.DropIndex(
                name: "IX_UserLanguage_ApplicationUserId",
                table: "UserLanguage");

            migrationBuilder.DropIndex(
                name: "IX_Link_ApplicationUserId",
                table: "Link");

            migrationBuilder.DropIndex(
                name: "IX_Experience_ApplicationUserId",
                table: "Experience");

            migrationBuilder.DropIndex(
                name: "IX_Education_ApplicationUserId",
                table: "Education");

            migrationBuilder.DropIndex(
                name: "IX_Course_ApplicationUserId",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "UserSkill");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "UserLanguage");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Link");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Experience");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Course");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "UserSkill",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "UserLanguage",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Link",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Experience",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Education",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Course",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_AspNetUsers_UserID",
                table: "Course",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Education_AspNetUsers_UserID",
                table: "Education",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Experience_AspNetUsers_UserID",
                table: "Experience",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Link_AspNetUsers_UserID",
                table: "Link",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLanguage_AspNetUsers_UserID",
                table: "UserLanguage",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSkill_AspNetUsers_UserID",
                table: "UserSkill",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_AspNetUsers_UserID",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Education_AspNetUsers_UserID",
                table: "Education");

            migrationBuilder.DropForeignKey(
                name: "FK_Experience_AspNetUsers_UserID",
                table: "Experience");

            migrationBuilder.DropForeignKey(
                name: "FK_Link_AspNetUsers_UserID",
                table: "Link");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLanguage_AspNetUsers_UserID",
                table: "UserLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSkill_AspNetUsers_UserID",
                table: "UserSkill");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "UserSkill",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "UserSkill",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "UserLanguage",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "UserLanguage",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Link",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Link",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Experience",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Experience",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Education",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Education",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Course",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Course",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyID = table.Column<int>(type: "int", nullable: true),
                    PositionID = table.Column<int>(type: "int", nullable: false),
                    UserAddressID = table.Column<int>(type: "int", nullable: false),
                    CVPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePicturePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkSummary = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_Address_UserAddressID",
                        column: x => x.UserAddressID,
                        principalTable: "Address",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Company_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Company",
                        principalColumn: "CompanyID");
                    table.ForeignKey(
                        name: "FK_User_Position_PositionID",
                        column: x => x.PositionID,
                        principalTable: "Position",
                        principalColumn: "PositionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserSkill_ApplicationUserId",
                table: "UserSkill",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLanguage_ApplicationUserId",
                table: "UserLanguage",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Link_ApplicationUserId",
                table: "Link",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Experience_ApplicationUserId",
                table: "Experience",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_ApplicationUserId",
                table: "Education",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_ApplicationUserId",
                table: "Course",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_CompanyID",
                table: "User",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_User_PositionID",
                table: "User",
                column: "PositionID");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserAddressID",
                table: "User",
                column: "UserAddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_AspNetUsers_ApplicationUserId",
                table: "Course",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_User_UserID",
                table: "Course",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Education_AspNetUsers_ApplicationUserId",
                table: "Education",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Education_User_UserID",
                table: "Education",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Experience_AspNetUsers_ApplicationUserId",
                table: "Experience",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Experience_User_UserID",
                table: "Experience",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Link_AspNetUsers_ApplicationUserId",
                table: "Link",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Link_User_UserID",
                table: "Link",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLanguage_AspNetUsers_ApplicationUserId",
                table: "UserLanguage",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserLanguage_User_UserID",
                table: "UserLanguage",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSkill_AspNetUsers_ApplicationUserId",
                table: "UserSkill",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserSkill_User_UserID",
                table: "UserSkill",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
