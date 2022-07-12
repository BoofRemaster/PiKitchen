using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PiKitchen.Dal.Migrations
{
    public partial class AddAuthenticationTableAndAddReferenceInTblUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE TABLE tblAuthenticationLevel (AuthenticationLevelId int NOT NULL, Name varchar(50) NOT NULL, PRIMARY KEY (AuthenticationLevelId))");
            migrationBuilder.Sql(@"INSERT INTO tblAuthenticationLevel (AuthenticationLevelId, Name) VALUES (1, 'StandardUser')");
            migrationBuilder.Sql(@"ALTER TABLE tblUser ADD AuthenticationLevelId int FOREIGN KEY(AuthenticationLevelId) REFERENCES tblAuthenticationLevel(AuthenticationLevelId)");
            migrationBuilder.Sql(@"UPDATE tblUser SET AuthenticationLevelId = 1");
        }
    }
}
