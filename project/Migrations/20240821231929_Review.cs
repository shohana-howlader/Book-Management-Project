using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project.Migrations
{
    /// <inheritdoc />
    public partial class Review : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "Reviews",
               columns: new[] { "Id", "BookId", "UserId", "Rating", "Comment", "DatePosted" },
               values: new object[,]
               {
                    { 1, 1, "5c830ccd-9837-4f09-87df-d2a20f4381ee", 3, "A good book for good life", new DateTime(2024, 8, 21, 22, 15, 34) },
                    { 2, 2, "5c830ccd-9837-4f09-87df-d2a20f4381ee", 5, "Nice book of this era", new DateTime(2024, 8, 21, 22, 16, 28) },
                    { 3, 2, "3a0af867-be88-4e0b-8cf6-80a4e3a30b8f", 3, "A captivating journey through vivid characters and thought-provoking themes, this book leaves a lasting impression on the reader's mind", new DateTime(2024, 8, 21, 22, 30, 40) },
                    { 4, 1, "3a0af867-be88-4e0b-8cf6-80a4e3a30b8f", 5, "A captivating journey through vivid characters and thought-provoking themes, this book leaves a lasting impression on the reader's mind", new DateTime(2024, 8, 21, 22, 30, 58) },
                    { 5, 3, "3a0af867-be88-4e0b-8cf6-80a4e3a30b8f", 4, "A captivating journey through vivid characters and thought-provoking themes, this book leaves a lasting impression on the reader's mind", new DateTime(2024, 8, 21, 22, 31, 07) },
                    { 6, 6, "3a0af867-be88-4e0b-8cf6-80a4e3a30b8f", 2, "A captivating journey through vivid characters and thought-provoking themes, this book leaves a lasting impression on the reader's mind", new DateTime(2024, 8, 21, 22, 31, 19) },
                    { 7, 1, "19969177-ce23-40c5-a98f-208a1c9a05ef", 3, "good Books", new DateTime(2024, 8, 21, 22, 43, 03) },
                    { 8, 1, "b03879ae-7c13-4930-81c5-246258494f8e", 5, "a group of sentences or a single sentence that forms a unit", new DateTime(2024, 8, 21, 22, 50, 51) }
               });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
               table: "Reviews",
               keyColumn: "Id",
               keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8);
	

        }
    }
}
