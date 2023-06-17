using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dataBlog.Data.Migrations
{
    /// <inheritdoc />
    public partial class Visitor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("1cefb42f-717e-4d3f-bfec-e2e4c9659396"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c154724e-5c5f-4732-840b-4a783d99563b"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("2d055654-5e6f-45ae-bc9d-9de9081e6793"), new Guid("35b37590-fa34-439a-8145-a60da485905c"), "Visual studio Blog là một nơi để bạn có thể chia sẻ những suy nghĩ, kinh nghiệm, thông tin và cảm xúc của mình với mọi người trên khắp thế giới. Bất kể bạn là một tác giả, nghệ sĩ, doanh nhân hay chỉ là một người đam mê viết lách, blog sẽ giúp bạn truyền tải những thông điệp của mình tới cộng đồng. Thông qua blog, bạn có thể kết nối với những người có cùng sở thích, học hỏi kinh nghiệm từ những người khác và đóng góp vào sự phát triển của cộng đồng trực tuyến.", "Admin Test", new DateTime(2023, 6, 12, 7, 59, 23, 157, DateTimeKind.Local).AddTicks(5254), null, null, new Guid("057a756b-6bd4-46b3-898a-96a0a1b26e52"), false, null, null, "Visual studio Core Blog VInfo", new Guid("390bc994-71d0-4966-a466-ab0b17daeabc"), 15 },
                    { new Guid("623a17c8-6ed4-4b51-8560-83f02b76c865"), new Guid("0828a694-67e0-42e8-bcdb-d6b2428c7c98"), "Asp.net Blog là một nơi để bạn có thể chia sẻ những suy nghĩ, kinh nghiệm, thông tin và cảm xúc của mình với mọi người trên khắp thế giới. Bất kể bạn là một tác giả, nghệ sĩ, doanh nhân hay chỉ là một người đam mê viết lách, blog sẽ giúp bạn truyền tải những thông điệp của mình tới cộng đồng. Thông qua blog, bạn có thể kết nối với những người có cùng sở thích, học hỏi kinh nghiệm từ những người khác và đóng góp vào sự phát triển của cộng đồng trực tuyến.", "Admin Test", new DateTime(2023, 6, 12, 7, 59, 23, 157, DateTimeKind.Local).AddTicks(5246), null, null, new Guid("2064ccb8-bda9-4800-ad53-5aba82dd4b06"), false, null, null, "Asp.net Core Blog VInfo", new Guid("ba4ec9e4-49e7-4102-a233-e63407d7e3e1"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2bcf7507-7151-4176-a040-b3378a804ab6"),
                column: "ConcurrencyStamp",
                value: "fe8db183-c6ac-4064-a8ea-3ab5238be29d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("96cc55aa-788c-421d-b610-bc3489d13f52"),
                column: "ConcurrencyStamp",
                value: "dce4e82f-2f0a-471a-9224-91938023b4c5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("affc7cf6-7ced-4dda-a558-fe1468f829ca"),
                column: "ConcurrencyStamp",
                value: "ef153a69-e409-4ef0-b939-51e0c62f762c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("390bc994-71d0-4966-a466-ab0b17daeabc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e54fe3ae-6d71-4120-98c2-d01733d8fd88", "AQAAAAEAACcQAAAAEOA/w1sytdLcYkPXcKB1Aorj0+n2OhHAejMpiJqJFO0p86NAWqw1RvCGjj5Ll6PFEg==", "c2783837-90fd-428f-b267-091378e34cf0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ba4ec9e4-49e7-4102-a233-e63407d7e3e1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bae31ce0-c63b-4c77-a113-ef437d153b01", "AQAAAAEAACcQAAAAECsruFl/NPUKxVVw9I/JF+gMhIUzQ7rseGExDMlZfREDmdJP39k8Mcspy0aD1k/xJQ==", "6d0a71e9-ba06-4721-9cfd-956f5d012023" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0828a694-67e0-42e8-bcdb-d6b2428c7c98"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 12, 7, 59, 23, 157, DateTimeKind.Local).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("35b37590-fa34-439a-8145-a60da485905c"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 12, 7, 59, 23, 157, DateTimeKind.Local).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("057a756b-6bd4-46b3-898a-96a0a1b26e52"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 12, 7, 59, 23, 157, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2064ccb8-bda9-4800-ad53-5aba82dd4b06"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 12, 7, 59, 23, 157, DateTimeKind.Local).AddTicks(5704));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("2d055654-5e6f-45ae-bc9d-9de9081e6793"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("623a17c8-6ed4-4b51-8560-83f02b76c865"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("1cefb42f-717e-4d3f-bfec-e2e4c9659396"), new Guid("35b37590-fa34-439a-8145-a60da485905c"), "Visual studio Blog là một nơi để bạn có thể chia sẻ những suy nghĩ, kinh nghiệm, thông tin và cảm xúc của mình với mọi người trên khắp thế giới. Bất kể bạn là một tác giả, nghệ sĩ, doanh nhân hay chỉ là một người đam mê viết lách, blog sẽ giúp bạn truyền tải những thông điệp của mình tới cộng đồng. Thông qua blog, bạn có thể kết nối với những người có cùng sở thích, học hỏi kinh nghiệm từ những người khác và đóng góp vào sự phát triển của cộng đồng trực tuyến.", "Admin Test", new DateTime(2023, 6, 12, 6, 13, 49, 881, DateTimeKind.Local).AddTicks(186), null, null, new Guid("057a756b-6bd4-46b3-898a-96a0a1b26e52"), false, null, null, "Visual studio Core Blog VInfo", new Guid("390bc994-71d0-4966-a466-ab0b17daeabc"), 15 },
                    { new Guid("c154724e-5c5f-4732-840b-4a783d99563b"), new Guid("0828a694-67e0-42e8-bcdb-d6b2428c7c98"), "Asp.net Blog là một nơi để bạn có thể chia sẻ những suy nghĩ, kinh nghiệm, thông tin và cảm xúc của mình với mọi người trên khắp thế giới. Bất kể bạn là một tác giả, nghệ sĩ, doanh nhân hay chỉ là một người đam mê viết lách, blog sẽ giúp bạn truyền tải những thông điệp của mình tới cộng đồng. Thông qua blog, bạn có thể kết nối với những người có cùng sở thích, học hỏi kinh nghiệm từ những người khác và đóng góp vào sự phát triển của cộng đồng trực tuyến.", "Admin Test", new DateTime(2023, 6, 12, 6, 13, 49, 881, DateTimeKind.Local).AddTicks(168), null, null, new Guid("2064ccb8-bda9-4800-ad53-5aba82dd4b06"), false, null, null, "Asp.net Core Blog VInfo", new Guid("ba4ec9e4-49e7-4102-a233-e63407d7e3e1"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("2bcf7507-7151-4176-a040-b3378a804ab6"),
                column: "ConcurrencyStamp",
                value: "256a2980-9954-420f-a3ee-acfaac6749a5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("96cc55aa-788c-421d-b610-bc3489d13f52"),
                column: "ConcurrencyStamp",
                value: "3f66bc9b-1869-4e90-8e33-95df6496e352");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("affc7cf6-7ced-4dda-a558-fe1468f829ca"),
                column: "ConcurrencyStamp",
                value: "39bc2145-f33e-4318-9151-39e572863952");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("390bc994-71d0-4966-a466-ab0b17daeabc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9985521-c05a-422b-a88f-9f74daa2492b", "AQAAAAEAACcQAAAAEOtQ82s31UC3/4n4T/EZYQypRPSxrFrTS2hfHgifzdoRZQqq1OM408AHZsn6Iy9BQQ==", "26d9ca3c-cf3b-4489-ae23-ef9bff081d45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ba4ec9e4-49e7-4102-a233-e63407d7e3e1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37bc0ce3-d498-49b4-badb-e3e9d2e45251", "AQAAAAEAACcQAAAAENVAXRgbPgd/hJ9icAbxq1whZW+bbxYAkyKMaK7WCta50xC6aOkJoBV2SNcmCphA/g==", "bc28e909-7329-4ee3-812c-2ee86ba2538a" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0828a694-67e0-42e8-bcdb-d6b2428c7c98"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 12, 6, 13, 49, 881, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("35b37590-fa34-439a-8145-a60da485905c"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 12, 6, 13, 49, 881, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("057a756b-6bd4-46b3-898a-96a0a1b26e52"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 12, 6, 13, 49, 881, DateTimeKind.Local).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2064ccb8-bda9-4800-ad53-5aba82dd4b06"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 12, 6, 13, 49, 881, DateTimeKind.Local).AddTicks(529));
        }
    }
}
