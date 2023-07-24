using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("01b61d49-a455-43cc-9069-6c22f733f80f"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("10e5cc97-c5c9-4534-99ea-e78708ed7e68"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5ae188f1-3e9a-477b-813f-166c4452c8d2"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7ac95399-aaa9-4da2-b457-6210a89e9847"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("81b7b328-3982-4fc5-921c-a5037d92d62b"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("9092c117-8d6c-477f-a85f-ec4d9c4aa521"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("90e33163-32ec-432c-b077-0205f6c086bb"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("9d095ee2-a082-43e2-a231-3e92497075e9"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("ad0baa50-8bd5-4e05-b3f6-5d81c3af0345"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("ae91c1de-bbdc-46a8-b60f-ad8f3cc9d3b0"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("d11d2e72-e17b-440d-99a0-f78db9773455"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("efa0ada8-c962-414c-b061-0191d8af3f76"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("05c3e085-cad0-417b-bc71-0ba4d3760a3e"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Amsterdam güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 30, 18, 345, DateTimeKind.Local).AddTicks(3308), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Amsterdam Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("1016da96-83a8-4669-9e31-9aa0a31ba389"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Roma güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 30, 18, 345, DateTimeKind.Local).AddTicks(3342), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Roma Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("5f7e1371-0c44-48ca-aa98-6c47dfe1f213"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Amalfi güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 30, 18, 345, DateTimeKind.Local).AddTicks(3336), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Amalfi Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("670c1935-0521-4b48-a025-ad2f197b9e55"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Barcelona güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 30, 18, 345, DateTimeKind.Local).AddTicks(3291), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, "Barcelona Seyahat Rehberi", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 },
                    { new Guid("6d5cd146-1c65-4340-b3e7-c8fd46d2ecf2"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Viyana güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 30, 18, 345, DateTimeKind.Local).AddTicks(3324), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Viyana Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("7ceeaaf9-35af-40a4-bacf-46cf613a4949"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Prag güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 30, 18, 345, DateTimeKind.Local).AddTicks(3357), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Prag Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("80814ae7-79be-4b6b-81e8-28d7ba57a087"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Selanik güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 30, 18, 345, DateTimeKind.Local).AddTicks(3350), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Selanik Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("885c4259-a6c1-4a99-9321-f24b2a416970"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Portofino güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 30, 18, 345, DateTimeKind.Local).AddTicks(3315), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Portofino Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("9fcd787a-c459-4b0c-994b-e3281ea58f0d"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Napoli güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 30, 18, 345, DateTimeKind.Local).AddTicks(3368), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Napoli Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("bc9bd8cb-47fe-43d8-9da7-7257d7db4d25"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Budapeşte güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 30, 18, 345, DateTimeKind.Local).AddTicks(3363), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Budapeşte Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("bf78f828-aee2-4e5e-baf4-b507de98bba2"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Paris güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 30, 18, 345, DateTimeKind.Local).AddTicks(3330), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Paris Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("f189bed6-a3cb-4437-8467-27a0eeb2dd37"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Zaandam güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 30, 18, 345, DateTimeKind.Local).AddTicks(3301), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Zaandam Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"),
                column: "ConcurrencyStamp",
                value: "54a84cf6-3848-4636-a483-33c711a6d585");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"),
                column: "ConcurrencyStamp",
                value: "8ab9cfd3-bf70-4005-8698-8cbecf6e6322");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"),
                column: "ConcurrencyStamp",
                value: "6d74fe78-4d9e-4c6c-bbfa-8c6b2c1442bb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07315aa1-45ca-41b1-a2e3-52fb26202b71", "AQAAAAEAACcQAAAAED5LxIlCdAyB+39pQin0JrB7i+BsV1nILBlt/9+aZoaUvxh7vkpYiwwBmZIMtUWPsg==", "1cb1aada-fb96-400a-b6a4-8520e3994ace" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dff5a547-d736-440a-b3cd-98751dcf5139", "AQAAAAEAACcQAAAAEOZfzU05uLaLNIaVLlaKu6ul3s7Oc/ECc0nBs13X0WbPxrHQt1GBQvJTpKQXcXjhdg==", "4e6e0d41-8035-40e0-8856-e07038700884" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 0, 30, 18, 345, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 0, 30, 18, 345, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 0, 30, 18, 345, DateTimeKind.Local).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 0, 30, 18, 345, DateTimeKind.Local).AddTicks(7478));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("05c3e085-cad0-417b-bc71-0ba4d3760a3e"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("1016da96-83a8-4669-9e31-9aa0a31ba389"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5f7e1371-0c44-48ca-aa98-6c47dfe1f213"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("670c1935-0521-4b48-a025-ad2f197b9e55"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("6d5cd146-1c65-4340-b3e7-c8fd46d2ecf2"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7ceeaaf9-35af-40a4-bacf-46cf613a4949"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("80814ae7-79be-4b6b-81e8-28d7ba57a087"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("885c4259-a6c1-4a99-9321-f24b2a416970"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("9fcd787a-c459-4b0c-994b-e3281ea58f0d"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("bc9bd8cb-47fe-43d8-9da7-7257d7db4d25"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("bf78f828-aee2-4e5e-baf4-b507de98bba2"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("f189bed6-a3cb-4437-8467-27a0eeb2dd37"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("01b61d49-a455-43cc-9069-6c22f733f80f"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Amsterdam güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 19, 2, 307, DateTimeKind.Local).AddTicks(6129), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Amsterdam Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("10e5cc97-c5c9-4534-99ea-e78708ed7e68"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Paris güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 19, 2, 307, DateTimeKind.Local).AddTicks(6147), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Paris Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("5ae188f1-3e9a-477b-813f-166c4452c8d2"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Napoli güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 19, 2, 307, DateTimeKind.Local).AddTicks(6225), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Napoli Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("7ac95399-aaa9-4da2-b457-6210a89e9847"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Zaandam güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 19, 2, 307, DateTimeKind.Local).AddTicks(6112), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Zaandam Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("81b7b328-3982-4fc5-921c-a5037d92d62b"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Portofino güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 19, 2, 307, DateTimeKind.Local).AddTicks(6135), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Portofino Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("9092c117-8d6c-477f-a85f-ec4d9c4aa521"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Prag güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 19, 2, 307, DateTimeKind.Local).AddTicks(6172), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Prag Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("90e33163-32ec-432c-b077-0205f6c086bb"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Amalfi güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 19, 2, 307, DateTimeKind.Local).AddTicks(6156), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Amalfi Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("9d095ee2-a082-43e2-a231-3e92497075e9"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Barcelona güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 19, 2, 307, DateTimeKind.Local).AddTicks(6104), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, "Barcelona Seyahat Rehberi", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 },
                    { new Guid("ad0baa50-8bd5-4e05-b3f6-5d81c3af0345"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Roma güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 19, 2, 307, DateTimeKind.Local).AddTicks(6162), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Roma Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("ae91c1de-bbdc-46a8-b60f-ad8f3cc9d3b0"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Budapeşte güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 19, 2, 307, DateTimeKind.Local).AddTicks(6181), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Budapeşte Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("d11d2e72-e17b-440d-99a0-f78db9773455"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Viyana güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 19, 2, 307, DateTimeKind.Local).AddTicks(6142), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Viyana Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("efa0ada8-c962-414c-b061-0191d8af3f76"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Selanik güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 19, 2, 307, DateTimeKind.Local).AddTicks(6167), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Selanik Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"),
                column: "ConcurrencyStamp",
                value: "17f7c86b-d43a-4d65-8ae3-ba488a6f588c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"),
                column: "ConcurrencyStamp",
                value: "3f0b9793-3973-423d-9330-d1eb7850052b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"),
                column: "ConcurrencyStamp",
                value: "9cfda56a-c209-4270-a7ec-0944f29937e4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87af8ddc-d60c-4f39-b0fd-63a892dca1ad", "AQAAAAEAACcQAAAAEKRzzgh4ih895qqCccjb0SCI7/pob/lciUH+96Zp8j3JvRQqfHfG74ZhLZkA9PX0og==", "1f4e301f-c893-4e9f-8b40-bfd49e0d1b53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c14c77e2-0a47-4f68-bd16-6a05f2c06614", "AQAAAAEAACcQAAAAEEtSQrPAyChGSF0j7WiQ8iE+nXZ6ZScoApawDlNXmndvznM8YHpIsiVvyEXa+PkDFw==", "c1147269-7044-4686-8110-73493c68d474" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 0, 19, 2, 307, DateTimeKind.Local).AddTicks(9919));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 0, 19, 2, 307, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 0, 19, 2, 308, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 0, 19, 2, 308, DateTimeKind.Local).AddTicks(91));
        }
    }
}
