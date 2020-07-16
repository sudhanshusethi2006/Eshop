using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EshopApp.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "order",
                columns: new[] { "Id", "OrderDate", "OrderNumber" },
                values: new object[] { 1, new DateTime(2020, 7, 16, 14, 32, 15, 774, DateTimeKind.Utc).AddTicks(6056), "12345" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "order",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
