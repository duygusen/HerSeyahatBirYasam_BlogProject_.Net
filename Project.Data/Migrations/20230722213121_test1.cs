using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class test1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("0c2ca522-aa47-459d-ad52-7d6209582e8c"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Amsterdam güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(248), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Amsterdam Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("108ec1bb-d981-4ad2-9bb8-1fde971ee2f8"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Zaandam güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(220), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Zaandam Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("120b0cb3-52e5-4e56-a0db-316abfebd2da"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Budapeşte güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(337), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Budapeşte Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("25613492-39ed-4d6a-90b9-abbd14f8989c"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Paris güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(281), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Paris Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("29b61a41-b1b9-45cc-bc0c-0d55cef74e10"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Napoli güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(347), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Napoli Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("41c32b8e-6b1d-46ef-b3bb-e83086224dfc"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Amalfi güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(295), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Amalfi Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("6a1f0416-db33-4aa1-897e-4ef5d3ec539a"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Selanik güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(315), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Selanik Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("6c61c065-a5ae-4752-a8bc-be45a89b3418"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Portofino güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(259), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Portofino Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("8073ccb8-f6bd-45c2-9f95-97929872209d"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Viyana güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(270), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Viyana Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("9a5b7a36-c8bb-42a5-959b-c482fc7b2262"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Prag güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(324), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Prag Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("b92a0eb8-f692-4d78-b383-6cb62ea8e608"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Barcelona güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(177), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, "Barcelona Seyahat Rehberi", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 },
                    { new Guid("bd837998-c3c1-4ee3-836b-25fc8b953d1c"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Roma güzel şehir", "superadmin", new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(305), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Roma Seyahat Rehberi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"),
                column: "ConcurrencyStamp",
                value: "b6296553-3389-497a-9d54-0f41c6d8b6da");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"),
                column: "ConcurrencyStamp",
                value: "60665ac4-e1d8-4910-aa41-41752e80e4ea");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"),
                column: "ConcurrencyStamp",
                value: "22ccd8f0-a7ae-473e-b509-765b832e4caf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b9b5773-c6f5-42d1-a87c-f3ed2be6666a", "AQAAAAEAACcQAAAAEP6lRvdlEl3X5qn6O4GaALJ+tq7969kpCcpoWjw6CTTZ7krMRqPW0fuZciamsmpVHQ==", "ae8fb223-321d-4092-afa6-f607882d4f53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a9ab31f-073f-411b-a086-492786249b9a", "AQAAAAEAACcQAAAAECxpGeAWkanbUPjIt3WwqsTgxqkuiNMD+rRcR4U1ZC3BwAs4LLM5VIEPlYp0zVf8DQ==", "d88588a3-c245-41a6-bd75-70068adcc3d4" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(5388));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("0c2ca522-aa47-459d-ad52-7d6209582e8c"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("108ec1bb-d981-4ad2-9bb8-1fde971ee2f8"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("120b0cb3-52e5-4e56-a0db-316abfebd2da"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("25613492-39ed-4d6a-90b9-abbd14f8989c"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("29b61a41-b1b9-45cc-bc0c-0d55cef74e10"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("41c32b8e-6b1d-46ef-b3bb-e83086224dfc"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("6a1f0416-db33-4aa1-897e-4ef5d3ec539a"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("6c61c065-a5ae-4752-a8bc-be45a89b3418"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("8073ccb8-f6bd-45c2-9f95-97929872209d"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("9a5b7a36-c8bb-42a5-959b-c482fc7b2262"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("b92a0eb8-f692-4d78-b383-6cb62ea8e608"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("bd837998-c3c1-4ee3-836b-25fc8b953d1c"));

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
    }
}
