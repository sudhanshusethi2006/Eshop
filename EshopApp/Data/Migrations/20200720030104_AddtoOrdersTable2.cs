using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EshopApp.Migrations
{
    public partial class AddtoOrdersTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "order",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "order",
                columns: new[] { "Id", "OrderDate", "OrderNumber", "Price", "isComplete" },
                values: new object[] { 2, new DateTime(2020, 7, 20, 3, 1, 4, 214, DateTimeKind.Utc).AddTicks(3066), "12346", 99m, false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "order",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "order",
                columns: new[] { "Id", "OrderDate", "OrderNumber", "Price", "isComplete" },
                values: new object[] { 1, new DateTime(2020, 7, 20, 2, 56, 45, 910, DateTimeKind.Utc).AddTicks(7568), "12345", 0m, false });
        }
    }
}
