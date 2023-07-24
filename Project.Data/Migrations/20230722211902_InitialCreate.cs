using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    DeletedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FileName = table.Column<string>(type: "TEXT", nullable: false),
                    FileType = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    DeletedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IpAddress = table.Column<string>(type: "TEXT", nullable: false),
                    UserAgent = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    ImageId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    ViewCount = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ImageId = table.Column<Guid>(type: "TEXT", nullable: true),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    DeletedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Articles_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    RoleId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticleVisitors",
                columns: table => new
                {
                    ArticleId = table.Column<Guid>(type: "TEXT", nullable: false),
                    VisitorId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleVisitors", x => new { x.ArticleId, x.VisitorId });
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_Visitors_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"), "17f7c86b-d43a-4d65-8ae3-ba488a6f588c", "Superadmin", "SUPERADMIN" },
                    { new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"), "3f0b9793-3973-423d-9330-d1eb7850052b", "Admin", "ADMIN" },
                    { new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"), "9cfda56a-c209-4270-a7ec-0944f29937e4", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "superadmin", new DateTime(2023, 7, 23, 0, 19, 2, 307, DateTimeKind.Local).AddTicks(9919), null, null, false, null, null, "Türkiye" },
                    { new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "superadmin", new DateTime(2023, 7, 23, 0, 19, 2, 307, DateTimeKind.Local).AddTicks(9924), null, null, false, null, null, "Dünya" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), "Admin", new DateTime(2023, 7, 23, 0, 19, 2, 308, DateTimeKind.Local).AddTicks(96), null, null, "/assets/img/blog/paris", "jpeg", false, null, null },
                    { new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), "Admin", new DateTime(2023, 7, 23, 0, 19, 2, 308, DateTimeKind.Local).AddTicks(91), null, null, "/assets/img/blog/amsterdam", "jpeg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageId", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 0, "87af8ddc-d60c-4f39-b0fd-63a892dca1ad", "admin@gmail.com", false, "Banu", new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), "Sen", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEKRzzgh4ih895qqCccjb0SCI7/pob/lciUH+96Zp8j3JvRQqfHfG74ZhLZkA9PX0og==", "+905999999999", false, "1f4e301f-c893-4e9f-8b40-bfd49e0d1b53", false, "admin@gmail.com" },
                    { new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 0, "c14c77e2-0a47-4f68-bd16-6a05f2c06614", "superadmin@gmail.com", true, "Duygu", new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), "Sen", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEEtSQrPAyChGSF0j7WiQ8iE+nXZ6ZScoApawDlNXmndvznM8YHpIsiVvyEXa+PkDFw==", "+905888888888", true, "c1147269-7044-4686-8110-73493c68d474", false, "superadmin@gmail.com" }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"), new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"), new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ImageId",
                table: "Articles",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_UserId",
                table: "Articles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleVisitors_VisitorId",
                table: "ArticleVisitors",
                column: "VisitorId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ImageId",
                table: "AspNetUsers",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleVisitors");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
