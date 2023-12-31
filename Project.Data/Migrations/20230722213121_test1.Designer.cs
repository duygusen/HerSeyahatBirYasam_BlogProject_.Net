﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.Data.Context;

#nullable disable

namespace Project.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230722213121_test1")]
    partial class test1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("Project.Entity.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"),
                            ConcurrencyStamp = "b6296553-3389-497a-9d54-0f41c6d8b6da",
                            Name = "Superadmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"),
                            ConcurrencyStamp = "60665ac4-e1d8-4910-aa41-41752e80e4ea",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"),
                            ConcurrencyStamp = "22ccd8f0-a7ae-473e-b509-765b832e4caf",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Project.Entity.Entities.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Project.Entity.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9a9ab31f-073f-411b-a086-492786249b9a",
                            Email = "superadmin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Duygu",
                            ImageId = new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                            LastName = "Sen",
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                            NormalizedUserName = "SUPERADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAECxpGeAWkanbUPjIt3WwqsTgxqkuiNMD+rRcR4U1ZC3BwAs4LLM5VIEPlYp0zVf8DQ==",
                            PhoneNumber = "+905888888888",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "d88588a3-c245-41a6-bd75-70068adcc3d4",
                            TwoFactorEnabled = false,
                            UserName = "superadmin@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0b9b5773-c6f5-42d1-a87c-f3ed2be6666a",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Banu",
                            ImageId = new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                            LastName = "Sen",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEP6lRvdlEl3X5qn6O4GaALJ+tq7969kpCcpoWjw6CTTZ7krMRqPW0fuZciamsmpVHQ==",
                            PhoneNumber = "+905999999999",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ae8fb223-321d-4092-afa6-f607882d4f53",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        });
                });

            modelBuilder.Entity("Project.Entity.Entities.AppUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Project.Entity.Entities.AppUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Project.Entity.Entities.AppUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                            RoleId = new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e")
                        },
                        new
                        {
                            UserId = new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                            RoleId = new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4")
                        });
                });

            modelBuilder.Entity("Project.Entity.Entities.AppUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Project.Entity.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ImageId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<int>("ViewCount")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.HasIndex("UserId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b92a0eb8-f692-4d78-b383-6cb62ea8e608"),
                            CategoryId = new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                            Content = "Barcelona güzel şehir",
                            CreatedBy = "superadmin",
                            CreatedDate = new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(177),
                            ImageId = new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                            IsDeleted = false,
                            Title = "Barcelona Seyahat Rehberi",
                            UserId = new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("108ec1bb-d981-4ad2-9bb8-1fde971ee2f8"),
                            CategoryId = new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                            Content = "Zaandam güzel şehir",
                            CreatedBy = "superadmin",
                            CreatedDate = new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(220),
                            ImageId = new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                            IsDeleted = false,
                            Title = "Zaandam Seyahat Rehberi",
                            UserId = new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("0c2ca522-aa47-459d-ad52-7d6209582e8c"),
                            CategoryId = new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                            Content = "Amsterdam güzel şehir",
                            CreatedBy = "superadmin",
                            CreatedDate = new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(248),
                            ImageId = new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                            IsDeleted = false,
                            Title = "Amsterdam Seyahat Rehberi",
                            UserId = new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("6c61c065-a5ae-4752-a8bc-be45a89b3418"),
                            CategoryId = new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                            Content = "Portofino güzel şehir",
                            CreatedBy = "superadmin",
                            CreatedDate = new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(259),
                            ImageId = new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                            IsDeleted = false,
                            Title = "Portofino Seyahat Rehberi",
                            UserId = new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("8073ccb8-f6bd-45c2-9f95-97929872209d"),
                            CategoryId = new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                            Content = "Viyana güzel şehir",
                            CreatedBy = "superadmin",
                            CreatedDate = new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(270),
                            ImageId = new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                            IsDeleted = false,
                            Title = "Viyana Seyahat Rehberi",
                            UserId = new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("25613492-39ed-4d6a-90b9-abbd14f8989c"),
                            CategoryId = new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                            Content = "Paris güzel şehir",
                            CreatedBy = "superadmin",
                            CreatedDate = new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(281),
                            ImageId = new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                            IsDeleted = false,
                            Title = "Paris Seyahat Rehberi",
                            UserId = new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("41c32b8e-6b1d-46ef-b3bb-e83086224dfc"),
                            CategoryId = new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                            Content = "Amalfi güzel şehir",
                            CreatedBy = "superadmin",
                            CreatedDate = new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(295),
                            ImageId = new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                            IsDeleted = false,
                            Title = "Amalfi Seyahat Rehberi",
                            UserId = new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("bd837998-c3c1-4ee3-836b-25fc8b953d1c"),
                            CategoryId = new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                            Content = "Roma güzel şehir",
                            CreatedBy = "superadmin",
                            CreatedDate = new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(305),
                            ImageId = new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                            IsDeleted = false,
                            Title = "Roma Seyahat Rehberi",
                            UserId = new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("6a1f0416-db33-4aa1-897e-4ef5d3ec539a"),
                            CategoryId = new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                            Content = "Selanik güzel şehir",
                            CreatedBy = "superadmin",
                            CreatedDate = new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(315),
                            ImageId = new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                            IsDeleted = false,
                            Title = "Selanik Seyahat Rehberi",
                            UserId = new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("9a5b7a36-c8bb-42a5-959b-c482fc7b2262"),
                            CategoryId = new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                            Content = "Prag güzel şehir",
                            CreatedBy = "superadmin",
                            CreatedDate = new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(324),
                            ImageId = new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                            IsDeleted = false,
                            Title = "Prag Seyahat Rehberi",
                            UserId = new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("120b0cb3-52e5-4e56-a0db-316abfebd2da"),
                            CategoryId = new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                            Content = "Budapeşte güzel şehir",
                            CreatedBy = "superadmin",
                            CreatedDate = new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(337),
                            ImageId = new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                            IsDeleted = false,
                            Title = "Budapeşte Seyahat Rehberi",
                            UserId = new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("29b61a41-b1b9-45cc-bc0c-0d55cef74e10"),
                            CategoryId = new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                            Content = "Napoli güzel şehir",
                            CreatedBy = "superadmin",
                            CreatedDate = new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(347),
                            ImageId = new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                            IsDeleted = false,
                            Title = "Napoli Seyahat Rehberi",
                            UserId = new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                            ViewCount = 15
                        });
                });

            modelBuilder.Entity("Project.Entity.Entities.ArticleVisitor", b =>
                {
                    b.Property<Guid>("ArticleId")
                        .HasColumnType("TEXT");

                    b.Property<int>("VisitorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ArticleId", "VisitorId");

                    b.HasIndex("VisitorId");

                    b.ToTable("ArticleVisitors");
                });

            modelBuilder.Entity("Project.Entity.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"),
                            CreatedBy = "superadmin",
                            CreatedDate = new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(4875),
                            IsDeleted = false,
                            Name = "Türkiye"
                        },
                        new
                        {
                            Id = new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                            CreatedBy = "superadmin",
                            CreatedDate = new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(4880),
                            IsDeleted = false,
                            Name = "Dünya"
                        });
                });

            modelBuilder.Entity("Project.Entity.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(5388),
                            FileName = "/assets/img/blog/amsterdam",
                            FileType = "jpeg",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                            CreatedBy = "Admin",
                            CreatedDate = new DateTime(2023, 7, 23, 0, 31, 20, 696, DateTimeKind.Local).AddTicks(5396),
                            FileName = "/assets/img/blog/paris",
                            FileType = "jpeg",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Project.Entity.Entities.Visitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("IpAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserAgent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Visitors");
                });

            modelBuilder.Entity("Project.Entity.Entities.AppRoleClaim", b =>
                {
                    b.HasOne("Project.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Project.Entity.Entities.AppUser", b =>
                {
                    b.HasOne("Project.Entity.Entities.Image", "Image")
                        .WithMany("Users")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");
                });

            modelBuilder.Entity("Project.Entity.Entities.AppUserClaim", b =>
                {
                    b.HasOne("Project.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Project.Entity.Entities.AppUserLogin", b =>
                {
                    b.HasOne("Project.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Project.Entity.Entities.AppUserRole", b =>
                {
                    b.HasOne("Project.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Project.Entity.Entities.AppUserToken", b =>
                {
                    b.HasOne("Project.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Project.Entity.Entities.Article", b =>
                {
                    b.HasOne("Project.Entity.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.Entity.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId");

                    b.HasOne("Project.Entity.Entities.AppUser", "User")
                        .WithMany("Articles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Project.Entity.Entities.ArticleVisitor", b =>
                {
                    b.HasOne("Project.Entity.Entities.Article", "Article")
                        .WithMany("ArticleVisitors")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.Entity.Entities.Visitor", "Visitor")
                        .WithMany("ArticleVisitors")
                        .HasForeignKey("VisitorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");

                    b.Navigation("Visitor");
                });

            modelBuilder.Entity("Project.Entity.Entities.AppUser", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("Project.Entity.Entities.Article", b =>
                {
                    b.Navigation("ArticleVisitors");
                });

            modelBuilder.Entity("Project.Entity.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("Project.Entity.Entities.Image", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Project.Entity.Entities.Visitor", b =>
                {
                    b.Navigation("ArticleVisitors");
                });
#pragma warning restore 612, 618
        }
    }
}
