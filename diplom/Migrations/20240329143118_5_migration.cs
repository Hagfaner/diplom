using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace diplom.Migrations
{
    /// <inheritdoc />
    public partial class _5_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "a9b7f969-63c2-4701-92d8-9b730c9f0d44", null, "admin", "admin" },
                    { "c799c0df-ff09-4b62-ba5f-c3553bdd0ca4", null, "user", "user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9b7f969-63c2-4701-92d8-9b730c9f0d44");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c799c0df-ff09-4b62-ba5f-c3553bdd0ca4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c8461f7-6b7c-4b1e-8027-fdc25dd3ee7e", null, "admin", "admin" },
                    { "e99e1a22-f9c8-41f2-9267-c207d4a87893", null, "user", "user" }
                });
        }
    }
}
