﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dataBlog.Data.Context;

#nullable disable

namespace dataBlog.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230416202426_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("libBlog.Entity.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("affc7cf6-7ced-4dda-a558-fe1468f829ca"),
                            ConcurrencyStamp = "de0b6327-df04-4ccc-a932-3b72a00c5fe8",
                            Name = "Superadmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = new Guid("96cc55aa-788c-421d-b610-bc3489d13f52"),
                            ConcurrencyStamp = "3ad7d641-c0cc-464e-9d8d-7bbf3f16b118",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("2bcf7507-7151-4176-a040-b3378a804ab6"),
                            ConcurrencyStamp = "4de4b286-fdb2-405f-9a18-e5984cfce373",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("libBlog.Entity.Entities.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("libBlog.Entity.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("ba4ec9e4-49e7-4102-a233-e63407d7e3e1"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "63a41ab6-0c76-43c5-8345-2f3b55b17b9a",
                            Email = "superadmin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Thinh",
                            ImageId = new Guid("2064ccb8-bda9-4800-ad53-5aba82dd4b06"),
                            LastName = "Nguyen",
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                            NormalizedUserName = "SUPERADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPwejAIUEfRjyAvypt8p4Q8BYV4LBy0rfwHYvRCHlARIehxPfH8PiV3ozLvrVi+sBw==",
                            PhoneNumber = "+84931381229",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "c094d19b-faa6-473c-b0bd-3945ea8db777",
                            TwoFactorEnabled = false,
                            UserName = "superadmin@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("390bc994-71d0-4966-a466-ab0b17daeabc"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "55aa92b8-0b96-46aa-8fee-a91f00d405e4",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            ImageId = new Guid("057a756b-6bd4-46b3-898a-96a0a1b26e52"),
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPjNYAqjXZY/1F4yIP8uJclfIm0hMQd0uXdpmkt/jsPtOxF0VosP/ZmMzq6YvhhViA==",
                            PhoneNumber = "+84931381229",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d1dcc963-1660-4bfa-a0cc-c04ef0b20f69",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        });
                });

            modelBuilder.Entity("libBlog.Entity.Entities.AppUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("libBlog.Entity.Entities.AppUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("libBlog.Entity.Entities.AppUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("ba4ec9e4-49e7-4102-a233-e63407d7e3e1"),
                            RoleId = new Guid("affc7cf6-7ced-4dda-a558-fe1468f829ca")
                        },
                        new
                        {
                            UserId = new Guid("390bc994-71d0-4966-a466-ab0b17daeabc"),
                            RoleId = new Guid("96cc55aa-788c-421d-b610-bc3489d13f52")
                        });
                });

            modelBuilder.Entity("libBlog.Entity.Entities.AppUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("libBlog.Entity.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.HasIndex("UserId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4917e36c-4ec4-47a1-8040-cad730d7ad75"),
                            CategoryId = new Guid("0828a694-67e0-42e8-bcdb-d6b2428c7c98"),
                            Content = "Asp.net Blog là một nơi để bạn có thể chia sẻ những suy nghĩ, kinh nghiệm, thông tin và cảm xúc của mình với mọi người trên khắp thế giới. Bất kể bạn là một tác giả, nghệ sĩ, doanh nhân hay chỉ là một người đam mê viết lách, blog sẽ giúp bạn truyền tải những thông điệp của mình tới cộng đồng. Thông qua blog, bạn có thể kết nối với những người có cùng sở thích, học hỏi kinh nghiệm từ những người khác và đóng góp vào sự phát triển của cộng đồng trực tuyến.",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 4, 17, 3, 24, 26, 137, DateTimeKind.Local).AddTicks(4167),
                            ImageId = new Guid("2064ccb8-bda9-4800-ad53-5aba82dd4b06"),
                            IsDeleted = false,
                            Title = "Asp.net Core Blog VInfo",
                            UserId = new Guid("ba4ec9e4-49e7-4102-a233-e63407d7e3e1"),
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("23ae5fa4-9130-46f5-8f9e-f53b6a01bcfb"),
                            CategoryId = new Guid("35b37590-fa34-439a-8145-a60da485905c"),
                            Content = "Visual studio Blog là một nơi để bạn có thể chia sẻ những suy nghĩ, kinh nghiệm, thông tin và cảm xúc của mình với mọi người trên khắp thế giới. Bất kể bạn là một tác giả, nghệ sĩ, doanh nhân hay chỉ là một người đam mê viết lách, blog sẽ giúp bạn truyền tải những thông điệp của mình tới cộng đồng. Thông qua blog, bạn có thể kết nối với những người có cùng sở thích, học hỏi kinh nghiệm từ những người khác và đóng góp vào sự phát triển của cộng đồng trực tuyến.",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 4, 17, 3, 24, 26, 137, DateTimeKind.Local).AddTicks(4175),
                            ImageId = new Guid("057a756b-6bd4-46b3-898a-96a0a1b26e52"),
                            IsDeleted = false,
                            Title = "Visual studio Core Blog VInfo",
                            UserId = new Guid("390bc994-71d0-4966-a466-ab0b17daeabc"),
                            ViewCount = 15
                        });
                });

            modelBuilder.Entity("libBlog.Entity.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0828a694-67e0-42e8-bcdb-d6b2428c7c98"),
                            CreatedBy = "admin test",
                            CreatedDate = new DateTime(2023, 4, 17, 3, 24, 26, 137, DateTimeKind.Local).AddTicks(4494),
                            IsDeleted = false,
                            Name = "ASP.NET Core"
                        },
                        new
                        {
                            Id = new Guid("35b37590-fa34-439a-8145-a60da485905c"),
                            CreatedBy = "admin test",
                            CreatedDate = new DateTime(2023, 4, 17, 3, 24, 26, 137, DateTimeKind.Local).AddTicks(4500),
                            IsDeleted = false,
                            Name = "Visual Studio 2022"
                        });
                });

            modelBuilder.Entity("libBlog.Entity.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2064ccb8-bda9-4800-ad53-5aba82dd4b06"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 4, 17, 3, 24, 26, 137, DateTimeKind.Local).AddTicks(4624),
                            FileName = "images/testimage",
                            FileType = "jpg",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("057a756b-6bd4-46b3-898a-96a0a1b26e52"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 4, 17, 3, 24, 26, 137, DateTimeKind.Local).AddTicks(4630),
                            FileName = "images/vstest",
                            FileType = "png",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("libBlog.Entity.Entities.AppRoleClaim", b =>
                {
                    b.HasOne("libBlog.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("libBlog.Entity.Entities.AppUser", b =>
                {
                    b.HasOne("libBlog.Entity.Entities.Image", "Image")
                        .WithMany("Users")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");
                });

            modelBuilder.Entity("libBlog.Entity.Entities.AppUserClaim", b =>
                {
                    b.HasOne("libBlog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("libBlog.Entity.Entities.AppUserLogin", b =>
                {
                    b.HasOne("libBlog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("libBlog.Entity.Entities.AppUserRole", b =>
                {
                    b.HasOne("libBlog.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("libBlog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("libBlog.Entity.Entities.AppUserToken", b =>
                {
                    b.HasOne("libBlog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("libBlog.Entity.Entities.Article", b =>
                {
                    b.HasOne("libBlog.Entity.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("libBlog.Entity.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId");

                    b.HasOne("libBlog.Entity.Entities.AppUser", "User")
                        .WithMany("Articles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");

                    b.Navigation("User");
                });

            modelBuilder.Entity("libBlog.Entity.Entities.AppUser", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("libBlog.Entity.Entities.Image", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
