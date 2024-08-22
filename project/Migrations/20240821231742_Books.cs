using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project.Migrations
{
    /// <inheritdoc />
    public partial class Books : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Title", "Author", "Genre", "PublishedDate", "PhotoUrl", "UserId", "Description" },
                values: new object[,]
                {
                    { 1, "Roktatto Prantor", "Munir Choudhury", "Golpo", new DateTime(2024, 1, 1), "/uploads/37f29045-ba2e-4f1a-9f55-9ca3842b55fd_Roktakto-Prantor-By-Monier-Choudhury.jpg", "5c830ccd-9837-4f09-87df-d2a20f4381ee", "Paragraphs are the building blocks of papers..." },
                    { 2, "Atomic Habits", "James Clear", "Nonfiction", new DateTime(2024, 1, 1), "/uploads/f03859fd-92b7-4ccf-8185-a231e2d6c761_OIP.jpeg", "5c830ccd-9837-4f09-87df-d2a20f4381ee", "Atomic Habits: An Easy & Proven Way to Build Good Habits..." },
                    { 3, "Opekkha", "Humayun Ahmed", "Novel", new DateTime(2024, 1, 1), "/uploads/261142fe-313c-4457-9376-2efa141d5cef_OIP (1).jpeg", "5c830ccd-9837-4f09-87df-d2a20f4381ee", "Humayun's younger brother, Muhammed Zafar Iqbal..." },
                    { 4, "The Moral Compass", "William J. Bennett", "Novel", new DateTime(2024, 1, 1), "/uploads/6c99f8ac-0e70-4fa3-a076-6bf9729f9489_download.png", "3a0af867-be88-4e0b-8cf6-80a4e3a30b8f", "Explore moral compass and learn the definition..." },
                    { 5, "Hada Voda Somogro", "Narayan Debnath", "Comics", new DateTime(2024, 1, 1), "/uploads/dd400bf0-dabe-40fa-80c0-9cfe72452d19_R.jpeg", "3a0af867-be88-4e0b-8cf6-80a4e3a30b8f", "Hada Voda Somogro by Narayan Debnath is popular Bengali Book..." },
                    { 6, "Shamali", "Rabindranath Tagore", "Poem", new DateTime(2024, 1, 1), "/uploads/51dac520-2a36-4c84-b120-aa249759d906_Shamali by Rabindranath Tagore - PDF Bangla Books.jpg", "3a0af867-be88-4e0b-8cf6-80a4e3a30b8f", "Shamali by Rabindranath Tagore is a popular Bengali Novel..." },
                    { 7, "কে কথা কয়", "হুমায়ুন আহমেদ", "Novel", new DateTime(2024, 1, 1), "/uploads/6e2a20c8-53d8-4b3d-94c2-7ece32a43db3_Ke Kotha Koy by Humayun Ahmed PDF Bangla Books.jpg", "19969177-ce23-40c5-a98f-208a1c9a05ef", "Ke Kotha Koi by Humayun Ahmed is a popular Bengali novel..." },
                    { 8, "ডোরা কাটা জামা", "সঞ্জীব চট্টোপাধ্যায়", "উপন্যাস", new DateTime(2024, 1, 1), "/uploads/Dorakata Jama by Sanjib Chattopadhyay pdf bangla Novel.jpg", "19969177-ce23-40c5-a98f-208a1c9a05ef", "Dorakata Jama by Sanjib Chattopadhyay is a Popular Bengali Book..." },
                    { 9, "Promila Golpo Songkolon", "Bijit Ghosh", "Golpo", new DateTime(2024, 1, 1), "/uploads/b31f67fe-2983-4df7-9928-cd35d4c1f8f7_Promila Golpo Songkolon edited by Bijit Ghosh PDF Bangla Story Collection.jpg", "b03879ae-7c13-4930-81c5-246258494f8e", "Promila Golpo Songkolon edited by Bijit Ghosh is a collection of Short Stories..." }
                });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9);

        }
    }
}
