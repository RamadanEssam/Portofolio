using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Editonnamee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("dfebf483-8be6-4aa9-a7a3-e4ceb8428bdd"));

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "Avatar", "FullName", "Profile" },
                values: new object[] { new Guid("24fc3b32-bc1f-46ab-a0a6-b090f04c2e12"), null, "avatar.jpg", "Ramadan Essam", "Microsoft MVP / .NET Consultant" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("24fc3b32-bc1f-46ab-a0a6-b090f04c2e12"));

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "Avatar", "FullName", "Profile" },
                values: new object[] { new Guid("dfebf483-8be6-4aa9-a7a3-e4ceb8428bdd"), null, "avatar.jpg", "Ramadan", "Asp . net Dev" });
        }
    }
}
