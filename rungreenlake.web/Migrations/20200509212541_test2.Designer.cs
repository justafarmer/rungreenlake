﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using rungreenlake.web.Data;

namespace rungreenlake.web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200509212541_test2")]
    partial class test2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("rungreenlake.Models.BuddyState", b =>
                {
                    b.Property<int>("FirstProfileID")
                        .HasColumnType("int");

                    b.Property<int>("SecondProfileID")
                        .HasColumnType("int");

                    b.Property<int?>("ProfileID")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("FirstProfileID", "SecondProfileID");

                    b.HasIndex("ProfileID");

                    b.HasIndex("SecondProfileID");

                    b.ToTable("BuddyList");
                });

            modelBuilder.Entity("rungreenlake.Models.Conversation", b =>
                {
                    b.Property<int>("ThreadID")
                        .HasColumnType("int");

                    b.Property<int>("MessageID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateRead")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReadFlag")
                        .HasColumnType("int");

                    b.HasKey("ThreadID", "MessageID");

                    b.HasIndex("MessageID")
                        .IsUnique();

                    b.ToTable("Conversations");
                });

            modelBuilder.Entity("rungreenlake.Models.Message", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateSent")
                        .HasColumnType("datetime2");

                    b.Property<string>("MsgBody")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MsgHeader")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MsgSenderID")
                        .HasColumnType("int");

                    b.Property<int?>("ProfileID")
                        .HasColumnType("int");

                    b.HasKey("MessageID");

                    b.HasIndex("ProfileID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("rungreenlake.Models.Profile", b =>
                {
                    b.Property<int>("ProfileID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LinkID")
                        .HasColumnType("int");

                    b.HasKey("ProfileID");

                    b.HasIndex("LinkID")
                        .IsUnique();

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("rungreenlake.Models.RaceRecord", b =>
                {
                    b.Property<int>("RaceRecordID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MileTime")
                        .HasColumnType("int");

                    b.Property<int>("ProfileID")
                        .HasColumnType("int");

                    b.Property<int>("RaceTime")
                        .HasColumnType("int");

                    b.Property<int>("RaceType")
                        .HasColumnType("int");

                    b.HasKey("RaceRecordID");

                    b.HasIndex("ProfileID");

                    b.ToTable("RaceRecords");
                });

            modelBuilder.Entity("rungreenlake.Models.Thread", b =>
                {
                    b.Property<int>("ThreadID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InitiatorID")
                        .HasColumnType("int");

                    b.Property<int?>("ProfileID")
                        .HasColumnType("int");

                    b.Property<int>("ReceiverID")
                        .HasColumnType("int");

                    b.HasKey("ThreadID");

                    b.HasIndex("InitiatorID");

                    b.HasIndex("ProfileID");

                    b.HasIndex("ReceiverID");

                    b.ToTable("Threads");
                });

            modelBuilder.Entity("rungreenlake.web.Areas.Identity.Data.RungreenlakeUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("LinkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("RunGreenLakeUsers");
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
                    b.HasOne("rungreenlake.web.Areas.Identity.Data.RungreenlakeUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("rungreenlake.web.Areas.Identity.Data.RungreenlakeUser", null)
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

                    b.HasOne("rungreenlake.web.Areas.Identity.Data.RungreenlakeUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("rungreenlake.web.Areas.Identity.Data.RungreenlakeUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("rungreenlake.Models.BuddyState", b =>
                {
                    b.HasOne("rungreenlake.Models.Profile", "FirstProfile")
                        .WithMany()
                        .HasForeignKey("FirstProfileID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("rungreenlake.Models.Profile", null)
                        .WithMany("Buddies")
                        .HasForeignKey("ProfileID");

                    b.HasOne("rungreenlake.Models.Profile", "SecondProfile")
                        .WithMany()
                        .HasForeignKey("SecondProfileID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("rungreenlake.Models.Conversation", b =>
                {
                    b.HasOne("rungreenlake.Models.Message", "Message")
                        .WithOne("Conversation")
                        .HasForeignKey("rungreenlake.Models.Conversation", "MessageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("rungreenlake.Models.Thread", "Thread")
                        .WithMany("Conversations")
                        .HasForeignKey("ThreadID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("rungreenlake.Models.Message", b =>
                {
                    b.HasOne("rungreenlake.Models.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileID");
                });

            modelBuilder.Entity("rungreenlake.Models.Profile", b =>
                {
                    b.HasOne("rungreenlake.web.Areas.Identity.Data.RungreenlakeUser", "LoginUser")
                        .WithOne("UserProfile")
                        .HasForeignKey("rungreenlake.Models.Profile", "LinkID")
                        .HasPrincipalKey("rungreenlake.web.Areas.Identity.Data.RungreenlakeUser", "LinkID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("rungreenlake.Models.RaceRecord", b =>
                {
                    b.HasOne("rungreenlake.Models.Profile", "RaceProfile")
                        .WithMany("TimeEntries")
                        .HasForeignKey("ProfileID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("rungreenlake.Models.Thread", b =>
                {
                    b.HasOne("rungreenlake.Models.Profile", "InitiatorProfile")
                        .WithMany()
                        .HasForeignKey("InitiatorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("rungreenlake.Models.Profile", null)
                        .WithMany("MessageThread")
                        .HasForeignKey("ProfileID");

                    b.HasOne("rungreenlake.Models.Profile", "ReceiverProfile")
                        .WithMany()
                        .HasForeignKey("ReceiverID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
