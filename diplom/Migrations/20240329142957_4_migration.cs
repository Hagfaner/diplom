using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace diplom.Migrations
{
    /// <inheritdoc />
    public partial class _4_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71f8c838-7b72-4368-9ac2-dc9a3554134a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4f1da7c-3a5e-40c3-a530-3cd6196abee9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c8461f7-6b7c-4b1e-8027-fdc25dd3ee7e", null, "admin", "admin" },
                    { "e99e1a22-f9c8-41f2-9267-c207d4a87893", null, "user", "user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c8461f7-6b7c-4b1e-8027-fdc25dd3ee7e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e99e1a22-f9c8-41f2-9267-c207d4a87893");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "71f8c838-7b72-4368-9ac2-dc9a3554134a", null, "admin", "admin" },
                    { "d4f1da7c-3a5e-40c3-a530-3cd6196abee9", null, "user", "user" }
                });
        }
    }
}
