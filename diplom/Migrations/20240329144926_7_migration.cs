using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace diplom.Migrations
{
    /// <inheritdoc />
    public partial class _7_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "30baa9c7-9fdc-4b07-aa8b-3d5b0a7cd5f5", null, "user", "user" },
                    { "b498dd4d-300d-4884-a468-aa87414ec2a3", null, "admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30baa9c7-9fdc-4b07-aa8b-3d5b0a7cd5f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b498dd4d-300d-4884-a468-aa87414ec2a3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ced7383-e973-42f2-910b-a2041016c430", null, "admin", "admin" },
                    { "7abca980-29e8-45be-abfe-c882186bf589", null, "user", "user" }
                });
        }
    }
}
