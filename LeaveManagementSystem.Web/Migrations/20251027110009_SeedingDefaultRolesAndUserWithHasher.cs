using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Web.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesAndUserWithHasher : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f7373cd-2764-4220-9d09-d35e32356aa8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f97b4b05-fdde-4b8f-9792-774ed1be924b", "AQAAAAIAAYagAAAAEOZtIWoQ2oVxh4aRVyPPerYio7BCxeekhnC93xyLdw5ArYJMVVvDJ3V9m6uAwIpvuA==", "66109c2e-dac9-497c-8314-7f0f6e59b96a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f7373cd-2764-4220-9d09-d35e32356aa8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c1a6198-ab7d-4522-bff4-f0b1c516f781", "eb2f27f29fa1c19a1186e5cf6716422d", "25f5368f-3c07-4456-ba51-1a28eb98f56f" });
        }
    }
}
