using Microsoft.EntityFrameworkCore.Migrations;

namespace NewCenter.Migrations
{
    public partial class NewsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "pubDate",
                table: "News",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pubDate",
                table: "News");
        }
    }
}
