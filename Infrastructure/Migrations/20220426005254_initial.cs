using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("0646c191-62dc-4ae1-9cd3-a851ad092772"));

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "Avatar", "FullName", "Profile" },
                values: new object[] { new Guid("dfebf483-8be6-4aa9-a7a3-e4ceb8428bdd"), null, "avatar.jpg", "Ramadan", "Asp . net Dev" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("dfebf483-8be6-4aa9-a7a3-e4ceb8428bdd"));

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "Avatar", "FullName", "Profile" },
                values: new object[] { new Guid("0646c191-62dc-4ae1-9cd3-a851ad092772"), null, "avatar.jpg", "Ramadan", "Asp . net Dev" });
        }
    }
}
