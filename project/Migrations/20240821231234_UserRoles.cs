using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Reflection.Emit;

#nullable disable

namespace project.Migrations
{
    /// <inheritdoc />
    public partial class UserRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "19969177-ce23-40c5-a98f-208a1c9a05ef", "6d13f88e-5381-48ec-9297-7bb3b757b48c" },
                    { "2b1e3262-3842-4928-bf88-c605d64a8f14", "6d13f88e-5381-48ec-9297-7bb3b757b48c" }, 
                    { "3a0af867-be88-4e0b-8cf6-80a4e3a30b8f", "6d13f88e-5381-48ec-9297-7bb3b757b48c" }, 
                    { "5c830ccd-9837-4f09-87df-d2a20f4381ee", "6d13f88e-5381-48ec-9297-7bb3b757b48c" },
                    { "b03879ae-7c13-4930-81c5-246258494f8e", "6d13f88e-5381-48ec-9297-7bb3b757b48c" }, 
                    { "2b1e3262-3842-4928-bf88-c605d64a8f14", "a599c23e-da42-4921-a61c-38771b502d69" }  
                });



        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "19969177-ce23-40c5-a98f-208a1c9a05ef", "6d13f88e-5381-48ec-9297-7bb3b757b48c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2b1e3262-3842-4928-bf88-c605d64a8f14", "6d13f88e-5381-48ec-9297-7bb3b757b48c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3a0af867-be88-4e0b-8cf6-80a4e3a30b8f", "6d13f88e-5381-48ec-9297-7bb3b757b48c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5c830ccd-9837-4f09-87df-d2a20f4381ee", "6d13f88e-5381-48ec-9297-7bb3b757b48c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b03879ae-7c13-4930-81c5-246258494f8e", "6d13f88e-5381-48ec-9297-7bb3b757b48c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2b1e3262-3842-4928-bf88-c605d64a8f14", "a599c23e-da42-4921-a61c-38771b502d69" });

        }
    }
}
