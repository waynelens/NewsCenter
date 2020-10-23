using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace NewCenter.Migrations
{
    public partial class SeedInsertTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "CreatTime","EditTime","IsDelete","RefCreatorId","RefEditorId","Name","Email","Password","Avator","RefPermissionId" },
                values: new object[] {DateTime.Now,null,false,1,null,"Admin","Admin@gmail.com","Admin0208", "https://avataaars.io/?avatarStyle=Transparent&topType=LongHairDreads&accessoriesType=Round&hairColor=SilverGray&facialHairType=BeardLight&facialHairColor=BrownDark&clotheType=CollarSweater&clotheColor=Gray01&eyeType=Dizzy&eyebrowType=UpDownNatural&mouthType=Default&skinColor=DarkBrown'", 1}
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
