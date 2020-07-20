using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EshopApp.Migrations
{
    public partial class AddingisCompletecolumnToOrdersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isComplete",
                table: "order",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "order",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2020, 7, 19, 2, 32, 44, 861, DateTimeKind.Utc).AddTicks(5425));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isComplete",
                table: "order");

            migrationBuilder.UpdateData(
                table: "order",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2020, 7, 19, 2, 29, 36, 747, DateTimeKind.Utc).AddTicks(6190));
        }
    }
}
