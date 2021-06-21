using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class mappinguserid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookmarkingUserId",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Bookmark",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookmarkingUserId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Bookmark");
        }
    }
}
