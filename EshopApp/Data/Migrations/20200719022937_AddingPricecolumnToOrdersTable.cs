using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EshopApp.Migrations
{
    public partial class AddingPricecolumnToOrdersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "order",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "order",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2020, 7, 19, 2, 29, 36, 747, DateTimeKind.Utc).AddTicks(6190));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "order");

            migrationBuilder.UpdateData(
                table: "order",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2020, 7, 16, 14, 32, 15, 774, DateTimeKind.Utc).AddTicks(6056));
        }
    }
}
