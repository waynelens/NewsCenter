using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewCenter.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookmarks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatTime = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    EditTime = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    RefCreatorId = table.Column<int>(nullable: false),
                    RefEditorId = table.Column<int>(nullable: false),
                    RefUserId = table.Column<string>(nullable: false),
                    RefNewsId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookmarks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatTime = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    EditTime = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    RefCreatorId = table.Column<int>(nullable: false),
                    RefEditorId = table.Column<int>(nullable: false),
                    Content = table.Column<string>(type: "nvarchar(Max)", nullable: false),
                    RefUserId = table.Column<int>(nullable: false),
                    RefNewsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatTime = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    EditTime = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    RefCreatorId = table.Column<int>(nullable: false),
                    RefEditorId = table.Column<int>(nullable: false),
                    Url = table.Column<string>(type: "nvarchar(Max)", nullable: false),
                    ThumbNail = table.Column<string>(type: "nvarchar(Max)", nullable: true),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    RefSourceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatTime = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    EditTime = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    RefCreatorId = table.Column<int>(nullable: false),
                    RefEditorId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sources",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatTime = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    EditTime = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    RefCreatorId = table.Column<int>(nullable: false),
                    RefEditorId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(Max)", nullable: true),
                    RssFeed = table.Column<string>(type: "nvarchar(Max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TagedNews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatTime = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    EditTime = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    RefCreatorId = table.Column<int>(nullable: false),
                    RefEditorId = table.Column<int>(nullable: false),
                    RefNewsId = table.Column<int>(nullable: false),
                    RefTagId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagedNews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatTime = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    EditTime = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    RefCreatorId = table.Column<int>(nullable: false),
                    RefEditorId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Upvotes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatTime = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    EditTime = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    RefCreatorId = table.Column<int>(nullable: false),
                    RefEditorId = table.Column<int>(nullable: false),
                    RefUserId = table.Column<int>(nullable: false),
                    RefNewsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Upvotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatTime = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    EditTime = table.Column<DateTime>(type: "datetime2(7)", nullable: false),
                    IsDelete = table.Column<bool>(nullable: false),
                    RefCreatorId = table.Column<int>(nullable: false),
                    RefEditorId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(Max)", nullable: true),
                    Avator = table.Column<string>(type: "nvarchar(Max)", nullable: true),
                    RefPermissionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookmarks");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "Sources");

            migrationBuilder.DropTable(
                name: "TagedNews");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Upvotes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
