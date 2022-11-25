using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ETicaret.DataAccessLayer.Migrations
{
    public partial class addCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CategoryStatus = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    SortKey = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "CategoryStatus", "SortKey" },
                values: new object[] { 1, "Elektronik", true, (short)1 });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "datetime",
                value: new DateTime(2022, 11, 25, 17, 8, 20, 681, DateTimeKind.Local).AddTicks(8896));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "datetime",
                value: new DateTime(2022, 11, 4, 18, 41, 53, 945, DateTimeKind.Local).AddTicks(5961));
        }
    }
}
