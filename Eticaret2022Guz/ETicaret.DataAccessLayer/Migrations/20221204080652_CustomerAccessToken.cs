using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace ETicaret.DataAccessLayer.Migrations
{
    public partial class CustomerAccessToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerPassword",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TokenExpireDate",
                table: "Customers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "datetime",
                value: new DateTime(2022, 12, 4, 11, 6, 51, 782, DateTimeKind.Local).AddTicks(5692));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerPassword",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Token",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "TokenExpireDate",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "datetime",
                value: new DateTime(2022, 11, 25, 17, 8, 20, 681, DateTimeKind.Local).AddTicks(8896));
        }
    }
}
