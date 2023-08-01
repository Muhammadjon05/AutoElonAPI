using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoElon.Data.Migrations
{
    /// <inheritdoc />
    public partial class inidsas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnnouncementUser_Announcements_AnnouncementId",
                table: "AnnouncementUser");

            migrationBuilder.DropForeignKey(
                name: "FK_AnnouncementUser_Users_UserId",
                table: "AnnouncementUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnnouncementUser",
                table: "AnnouncementUser");

            migrationBuilder.RenameTable(
                name: "AnnouncementUser",
                newName: "AnnouncementUsers");

            migrationBuilder.RenameIndex(
                name: "IX_AnnouncementUser_UserId",
                table: "AnnouncementUsers",
                newName: "IX_AnnouncementUsers_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AnnouncementUser_AnnouncementId",
                table: "AnnouncementUsers",
                newName: "IX_AnnouncementUsers_AnnouncementId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnnouncementUsers",
                table: "AnnouncementUsers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AnnouncementUsers_Announcements_AnnouncementId",
                table: "AnnouncementUsers",
                column: "AnnouncementId",
                principalTable: "Announcements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnnouncementUsers_Users_UserId",
                table: "AnnouncementUsers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnnouncementUsers_Announcements_AnnouncementId",
                table: "AnnouncementUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AnnouncementUsers_Users_UserId",
                table: "AnnouncementUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnnouncementUsers",
                table: "AnnouncementUsers");

            migrationBuilder.RenameTable(
                name: "AnnouncementUsers",
                newName: "AnnouncementUser");

            migrationBuilder.RenameIndex(
                name: "IX_AnnouncementUsers_UserId",
                table: "AnnouncementUser",
                newName: "IX_AnnouncementUser_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AnnouncementUsers_AnnouncementId",
                table: "AnnouncementUser",
                newName: "IX_AnnouncementUser_AnnouncementId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnnouncementUser",
                table: "AnnouncementUser",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AnnouncementUser_Announcements_AnnouncementId",
                table: "AnnouncementUser",
                column: "AnnouncementId",
                principalTable: "Announcements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnnouncementUser_Users_UserId",
                table: "AnnouncementUser",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
