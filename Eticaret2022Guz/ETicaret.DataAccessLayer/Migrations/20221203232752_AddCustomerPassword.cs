using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ETicaret.DataAccessLayer.Migrations
{
    public partial class AddCustomerPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerPassword",
                table: "Customers",
                type: "varchar(256)",
                maxLength: 256,
                nullable: true,
                defaultValue: "123456");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "datetime", "CustomerPassword" },
                values: new object[] { new DateTime(2022, 12, 4, 2, 27, 52, 576, DateTimeKind.Local).AddTicks(3882), "123456" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerPassword",
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
