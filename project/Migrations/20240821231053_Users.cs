using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project.Migrations
{
    /// <inheritdoc />
    public partial class Users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[]
                {
                    "Id", "FullName", "BirthDate", "Address", "City", "State",
                    "PostalCode", "Country", "Photo", "UserName", "NormalizedUserName",
                    "Email", "NormalizedEmail", "EmailConfirmed", "PasswordHash",
                    "SecurityStamp", "ConcurrencyStamp", "PhoneNumber",
                    "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEnd",
                    "LockoutEnabled", "AccessFailedCount"
                },
                values: new object[,]
                {
                    { "19969177-ce23-40c5-a98f-208a1c9a05ef", "User2", new DateTime(2024, 1, 1), "abc", "abc", "bcd", "123", "Bangladesh", null, "User2@gmail.com", "USER2@GMAIL.COM", "User2@gmail.com", "USER2@GMAIL.COM", false, "AQAAAAIAAYagAAAAEHv1KdCKO985DrAHiLzutzsyF3ChxBwbSHLownXFGpX3qYVGL5KKgdo/zpoYDvsaWw==", "RI3IW2VSX3UISEYXY3WD2GBTL6ZAZFTI", "14802cd2-403f-4669-80fd-74c3f4ede2bd", "01544", false, false, null, true, 0 },
                    { "2b1e3262-3842-4928-bf88-c605d64a8f14", "Admin", null, null, null, null, null, null, null, "Admin@gmail.com", "ADMIN@GMAIL.COM", "Admin@gmail.com", "ADMIN@GMAIL.COM", false, "AQAAAAIAAYagAAAAEIudkMASgiIiA1gtEy3dVerFn+IkhFwd1Rx1Fy3X3kIKQzMx7S9IAXVUv2QTnjRmUg==", "Q56MFZAHV55EXRNH2357PVMTGWLBWDIK", "570170d2-f8af-4583-a816-05a87c7e8cb9", null, false, false, null, true, 0 },
                    { "3a0af867-be88-4e0b-8cf6-80a4e3a30b8f", "User1", new DateTime(2024, 1, 1), "abc", "abc", "bcd", "123", "Bangladesh", null, "User1@gmail.com", "USER1@GMAIL.COM", "User1@gmail.com", "USER1@GMAIL.COM", false, "AQAAAAIAAYagAAAAEOfpGy8NAXGelc3KcBVk+93VHpYKPAWo28bh5bkKHQy0smgaN5k0lH1OpTugouSpSg==", "5HHVN73BSWBGEGNCWRG6ZDZMDENLDCIA", "3041498e-1f61-4b7e-a2da-6e4fcbc57ae7", "01544", false, false, null, true, 0 },
                    { "5c830ccd-9837-4f09-87df-d2a20f4381ee", "User", new DateTime(2024, 1, 1), "abc", "abc", "bcd", "123", "Bangladesh", null, "user@gmail.com", "USER@GMAIL.COM", "user@gmail.com", "USER@GMAIL.COM", false, "AQAAAAIAAYagAAAAEPh3UM1Y++PEJ26Pmr1dYcj4mPkCSgyNPG6kezWTZBnkMHCqZyDTS7PFNwovXtzpFQ==", "EB5FGW7BZSVQUR4RW2NOAOB6JEXWPHQS", "c361b72d-91e5-4a45-ba1c-c9d940792944", "01544", false, false, null, true, 0 },
                    { "b03879ae-7c13-4930-81c5-246258494f8e", "User3", null, null, null, null, null, null, null, "User3@gmail.com", "USER3@GMAIL.COM", "User3@gmail.com", "USER3@GMAIL.COM", false, "AQAAAAIAAYagAAAAEAmbsG0eC93sFbGewaWDTVTBe/fL4ByxuqDAX7P63YX/0Iw6Xf3QyYWc6p7r2vV6fA==", "OZJKJK7CSLPN6UGAPFX67XB4N7SYS3MS", "e013f754-1eb8-4d79-8365-2f2a4c2759f6", null, false, false, null, true, 0 }
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19969177-ce23-40c5-a98f-208a1c9a05ef"
            );

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b1e3262-3842-4928-bf88-c605d64a8f14"
            );

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a0af867-be88-4e0b-8cf6-80a4e3a30b8f"
            );

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c830ccd-9837-4f09-87df-d2a20f4381ee"
            );

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b03879ae-7c13-4930-81c5-246258494f8e"
            );
        }
    }
}
