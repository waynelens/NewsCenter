using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace NewCenter.Migrations
{
    public partial class SeedInsert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "News",
                type: "nvarchar(Max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RefUserId",
                table: "Bookmarks",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "RefNewsId",
                table: "Bookmarks",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
               table: "Bookmarks",
               columns: new[] { "CreatTime", "EditTime", "IsDelete", "RefCreatorId", "RefEditorId", "RefUserId", "RefNewsId" },
               values: new object[] { DateTime.Now, null, false, 3, null, 3, 1 }
           );
            migrationBuilder.InsertData(
               table: "News",
               columns: new[] { "CreatTime", "EditTime", "IsDelete", "RefCreatorId", "RefEditorId", "Url", "Thumbnail", "Title", "RefSourceId" },
               values: new object[] { DateTime.Now, null, false, 3, null, "https://developer.apple.com/news/?id=1eiyhoai", false, "Apple Entrepreneur Camp applications open for Black founders and developers", 1 }
           );
            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "CreatTime", "EditTime", "IsDelete", "RefCreatorId", "RefEditorId", "Name", "Logo", "RssFeed" },
                values: new object[] { DateTime.Now, null, false, 3, null, "Apple Developer", "https://i.imgur.com/uoIAm9n.png", "https://developer.apple.com/news/rss/news.rss" }
            );

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "CreatTime", "EditTime", "IsDelete", "RefCreatorId", "RefEditorId", "Name" },
                values: new object[] { DateTime.Now, null, false, 3, null, "Admin" }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "News",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(Max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RefUserId",
                table: "Bookmarks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "RefNewsId",
                table: "Bookmarks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
