using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EshopApp.Migrations
{
    public partial class AddtoOrdersTable3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "order",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "OrderDate", "Price", "isComplete" },
                values: new object[] { new DateTime(2020, 7, 20, 3, 5, 35, 990, DateTimeKind.Utc).AddTicks(9527), 120.98m, true });

            migrationBuilder.InsertData(
                table: "order",
                columns: new[] { "Id", "OrderDate", "OrderNumber", "Price", "isComplete" },
                values: new object[] { 3, new DateTime(2020, 7, 20, 3, 5, 35, 990, DateTimeKind.Utc).AddTicks(9557), "12347", 150.00m, false });

            migrationBuilder.InsertData(
                table: "order",
                columns: new[] { "Id", "OrderDate", "OrderNumber", "Price", "isComplete" },
                values: new object[] { 1, new DateTime(2020, 7, 20, 3, 5, 35, 990, DateTimeKind.Utc).AddTicks(7865), "12345", 99.23m, false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "order",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "order",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "order",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "OrderDate", "Price", "isComplete" },
                values: new object[] { new DateTime(2020, 7, 20, 3, 1, 4, 214, DateTimeKind.Utc).AddTicks(3066), 99m, false });
        }
    }
}
