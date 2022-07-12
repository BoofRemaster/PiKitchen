using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PiKitchen.Dal.Migrations
{
    public partial class UpdateTblUserColumnAuthenticationLevelIdToNotNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"ALTER TABLE tblUser ALTER COLUMN AuthenticationLevelId int NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
