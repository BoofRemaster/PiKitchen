using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PiKitchen.Dal.Migrations
{
    public partial class AddUserJulieannaBarrettToTblUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO tblUser (FirstName, LastName) VALUES ('Julieanna', 'Barrett')");
        }
    }
}
