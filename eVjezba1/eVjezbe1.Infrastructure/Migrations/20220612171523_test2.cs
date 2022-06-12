using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eVjezbe1.Infrastructure.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created_At", "FirstName", "Gender", "Hash", "LastName", "Password", "Updated_At", "UserName", "isDeleted" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dena", null, "rrrr2", "dena", "test", null, "dena@fit.ba", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
