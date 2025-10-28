using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Migrations
{
    /// <inheritdoc />
    public partial class ExtentedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f7373cd-2764-4220-9d09-d35e32356aa8",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db612cd2-f2d9-486f-83ae-8cb4a22bbe8d", new DateOnly(1998, 12, 30), "Default", "Admin", "AQAAAAIAAYagAAAAEApyiy4xYbRZenQtfKO8i7NFDgkh3JTQBAfhCcWdVKT98dHXN7WgR5ihM7XR5C90oQ==", "25dcf824-4be2-4ee0-9853-ca65fadeb4b4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f7373cd-2764-4220-9d09-d35e32356aa8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f97b4b05-fdde-4b8f-9792-774ed1be924b", "AQAAAAIAAYagAAAAEOZtIWoQ2oVxh4aRVyPPerYio7BCxeekhnC93xyLdw5ArYJMVVvDJ3V9m6uAwIpvuA==", "66109c2e-dac9-497c-8314-7f0f6e59b96a" });
        }
    }
}
