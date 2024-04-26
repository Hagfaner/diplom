using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace diplom.Migrations
{
    /// <inheritdoc />
    public partial class _6_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "0ced7383-e973-42f2-910b-a2041016c430", null, "admin", "admin" },
                    { "7abca980-29e8-45be-abfe-c882186bf589", null, "user", "user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ced7383-e973-42f2-910b-a2041016c430");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7abca980-29e8-45be-abfe-c882186bf589");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a9b7f969-63c2-4701-92d8-9b730c9f0d44", null, "admin", "admin" },
                    { "c799c0df-ff09-4b62-ba5f-c3553bdd0ca4", null, "user", "user" }
                });
        }
    }
}
