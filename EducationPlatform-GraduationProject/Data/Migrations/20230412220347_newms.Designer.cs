﻿// <auto-generated />
using System;
using EducationPlatform_GraduationProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EducationPlatform_GraduationProject.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230412220347_newms")]
    partial class newms
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EducationPlatform_GraduationProject.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("EducationPlatform_GraduationProject.Models.Chat", b =>
                {
                    b.Property<int>("ChatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChatId"), 1L, 1);

                    b.Property<int>("ClassIDFK")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChatId");

                    b.HasIndex("ClassIDFK")
                        .IsUnique();

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("EducationPlatform_GraduationProject.Models.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassId"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("EducationPlatform_GraduationProject.Models.Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClassID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClassID");

                    b.ToTable("Contents");
                });

            modelBuilder.Entity("EducationPlatform_GraduationProject.Models.ContentImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ContentID")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContentID");

                    b.ToTable("ContentImages");
                });

            modelBuilder.Entity("EducationPlatform_GraduationProject.Models.ContentPDFs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ContentID")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContentID");

                    b.ToTable("ContentPDFs");
                });

            modelBuilder.Entity("EducationPlatform_GraduationProject.Models.ContentVideos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ContentID")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContentID");

                    b.ToTable("ContentVideos");
                });

            modelBuilder.Entity("EducationPlatform_GraduationProject.Models.Messages", b =>
                {
                    b.Property<int>("MId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MId"), 1L, 1);

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ChatID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("StID")
                        .HasColumnType("int");

                    b.HasKey("MId");

                    b.HasIndex("ChatID");

                    b.HasIndex("StID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("EducationPlatform_GraduationProject.Models.Months", b =>
                {
                    b.Property<int>("MonthId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MonthId"), 1L, 1);

                    b.Property<bool?>("Apr")
                        .HasColumnType("bit");

                    b.Property<bool?>("Aug")
                        .HasColumnType("bit");

                    b.Property<bool?>("Dec")
                        .HasColumnType("bit");

                    b.Property<bool?>("Feb")
                        .HasColumnType("bit");

                    b.Property<bool?>("Jan")
                        .HasColumnType("bit");

                    b.Property<bool?>("Jul")
                        .HasColumnType("bit");

                    b.Property<bool?>("Jun")
                        .HasColumnType("bit");

                    b.Property<bool?>("Mar")
                        .HasColumnType("bit");

                    b.Property<bool?>("May")
                        .HasColumnType("bit");

                    b.Property<bool?>("Nov")
                        .HasColumnType("bit");

                    b.Property<bool?>("Oct")
                        .HasColumnType("bit");

                    b.Property<bool?>("Sep")
                        .HasColumnType("bit");

                    b.Property<int>("StID")
                        .HasColumnType("int");

                    b.HasKey("MonthId");

                    b.HasIndex("StID");

                    b.ToTable("Months");
                });

            modelBuilder.Entity("EducationPlatform_GraduationProject.Models.Student", b =>
                {
                    b.Property<int>("StId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StId"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClassID")
                        .HasColumnType("int");

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegistedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StId");

                    b.HasIndex("ClassID");

                    b.HasIndex("IdentityUserId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("EducationPlatform_GraduationProject.Models.Chat", b =>
                {
                    b.HasOne("EducationPlatform_GraduationProject.Models.Class", "Class")
                        .WithOne("Chat")
                        .HasForeignKey("EducationPlatform_GraduationProject.Models.Chat", "ClassIDFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("EducationPlatform_GraduationProject.Models.Content", b =>
                {
                    b.HasOne("EducationPlatform_GraduationProject.Models.Class", "Class")
                        .WithMany("Contents")
                        .HasForeignKey("ClassID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");
                });

            modelBuilder.Entity("EducationPlatform_GraduationProject.Models.ContentImage", b =>
                {
                    b.HasOne("EducationPlatform_GraduationProject.Models.Content", "Content")
                        .WithMany("Images")
                        .HasForeignKey("ContentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Content");
                });

            modelBuilder.Entity("EducationPlatform_GraduationProject.Models.ContentPDFs", b =>
                {
                    b.HasOne("EducationPlatform_GraduationProject.Models.Content", "Content")
                        .WithMany("PDFs")
                        .HasForeignKey("ContentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Content");
                });

            modelBuilder.Entity("EducationPlatform_GraduationProject.Models.ContentVideos", b =>
                {
                    b.HasOne("EducationPlatform_GraduationProject.Models.Content", "Content")
                        .WithMany("Videos")
                        .HasForeignKey("ContentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Content");
                });

            modelBuilder.Entity("EducationPlatform_GraduationProject.Models.Messages", b =>
                {
                    b.HasOne("EducationPlatform_GraduationProject.Models.Chat", "Chat")
                        .WithMany("Messages")
                        .HasForeignKey("ChatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EducationPlatform_GraduationProject.Models.Student", "Student")
                        .WithMany("Messages")
                        .HasForeignKey("StID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chat");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("EducationPlatform_GraduationProject.Models.Months", b =>
                {
                    b.HasOne("EducationPlatform_GraduationProject.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("EducationPlatform_GraduationProject.Models.Student", b =>
                {
                    b.HasOne("EducationPlatform_GraduationProject.Models.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EducationPlatform_GraduationProject.Models.ApplicationUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");

                    b.Navigation("Class");

                    b.Navigation("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("EducationPlatform_GraduationProject.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EducationPlatform_GraduationProject.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EducationPlatform_GraduationProject.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EducationPlatform_GraduationProject.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EducationPlatform_GraduationProject.Models.Chat", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("EducationPlatform_GraduationProject.Models.Class", b =>
                {
                    b.Navigation("Chat")
                        .IsRequired();

                    b.Navigation("Contents");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("EducationPlatform_GraduationProject.Models.Content", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("PDFs");

                    b.Navigation("Videos");
                });

            modelBuilder.Entity("EducationPlatform_GraduationProject.Models.Student", b =>
                {
                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
