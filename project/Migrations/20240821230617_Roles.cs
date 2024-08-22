using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project.Migrations
{
    /// <inheritdoc />
    public partial class Roles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                values: new object[,]
                {
                    { "6d13f88e-5381-48ec-9297-7bb3b757b48c", "User", "USER", null },
                    { "a599c23e-da42-4921-a61c-38771b502d69", "Admin", "ADMIN", null },
                    { "f1f0c962-2975-4358-b114-dd4f2e78445d", "Manager", "MANAGER", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d13f88e-5381-48ec-9297-7bb3b757b48c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a599c23e-da42-4921-a61c-38771b502d69");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1f0c962-2975-4358-b114-dd4f2e78445d");
        }
    }
}
