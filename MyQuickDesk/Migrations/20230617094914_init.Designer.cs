﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyQuickDesk.DatabaseContext;

#nullable disable

namespace MyQuickDesk.Migrations
{
    [DbContext(typeof(MyQuickDeskContext))]
    [Migration("20230617094914_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MyQuickDesk.Entities.Reservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DeskId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ParkingSpotId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("RoomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SpaceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DeskId");

                    b.HasIndex("ParkingSpotId");

                    b.HasIndex("RoomId");

                    b.HasIndex("SpaceId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("MyQuickDesk.Entities.Space", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedById")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvaiable")
                        .HasColumnType("bit");

                    b.Property<int>("MaxCapacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.ToTable("Spaces");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Space");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("MyQuickDesk.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Owner")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ReservationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MyQuickDesk.Entities.Desk", b =>
                {
                    b.HasBaseType("MyQuickDesk.Entities.Space");

                    b.HasDiscriminator().HasValue("Desk");

                    b.HasData(
                        new
                        {
                            Id = new Guid("79982234-50f5-4090-af04-bf79fcb712e1"),
                            IsAvaiable = true,
                            MaxCapacity = 1,
                            Name = "Biurko A1"
                        },
                        new
                        {
                            Id = new Guid("aa2b3d1f-1130-4937-a3ff-a2688b8d2c65"),
                            IsAvaiable = true,
                            MaxCapacity = 1,
                            Name = "Biurko A2"
                        },
                        new
                        {
                            Id = new Guid("cde03ef2-1943-4347-891c-84c64c9064c8"),
                            IsAvaiable = true,
                            MaxCapacity = 1,
                            Name = "Biurko A3"
                        },
                        new
                        {
                            Id = new Guid("007915dd-f143-49f8-8b7d-81a88039ae12"),
                            IsAvaiable = true,
                            MaxCapacity = 1,
                            Name = "Biurko B1"
                        },
                        new
                        {
                            Id = new Guid("b16417b9-f352-4c97-850c-4bd473b6f42e"),
                            IsAvaiable = true,
                            MaxCapacity = 1,
                            Name = "Biurko B2"
                        });
                });

            modelBuilder.Entity("MyQuickDesk.Entities.ParkingSpot", b =>
                {
                    b.HasBaseType("MyQuickDesk.Entities.Space");

                    b.Property<bool>("Charger")
                        .HasColumnType("bit");

                    b.Property<bool>("HandicappedSpot")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("ParkingSpot");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8e149143-d8b1-4be9-82a3-1f85d743e3b4"),
                            IsAvaiable = true,
                            MaxCapacity = 1,
                            Name = "P1A1",
                            Charger = true,
                            HandicappedSpot = true
                        },
                        new
                        {
                            Id = new Guid("28b68e12-25ce-43e4-9d2f-d01681d62125"),
                            IsAvaiable = true,
                            MaxCapacity = 1,
                            Name = "P1A2",
                            Charger = true,
                            HandicappedSpot = true
                        },
                        new
                        {
                            Id = new Guid("be7742d8-2c70-4a81-a9e9-c69b3d7f17c1"),
                            IsAvaiable = true,
                            MaxCapacity = 1,
                            Name = "P1A3",
                            Charger = true,
                            HandicappedSpot = true
                        },
                        new
                        {
                            Id = new Guid("383fb004-8b26-476d-b346-0354dbe21d1e"),
                            IsAvaiable = true,
                            MaxCapacity = 1,
                            Name = "P1B1",
                            Charger = true,
                            HandicappedSpot = true
                        });
                });

            modelBuilder.Entity("MyQuickDesk.Entities.Room", b =>
                {
                    b.HasBaseType("MyQuickDesk.Entities.Space");

                    b.HasDiscriminator().HasValue("Room");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ef76a914-5e15-4a23-988e-432e4c7caf8a"),
                            IsAvaiable = true,
                            MaxCapacity = 8,
                            Name = "Mariacka"
                        },
                        new
                        {
                            Id = new Guid("450d185a-dc3a-43de-bc7f-901b37e540cd"),
                            IsAvaiable = true,
                            MaxCapacity = 10,
                            Name = "Neptun"
                        },
                        new
                        {
                            Id = new Guid("c3e20e90-cc44-45fe-8e37-886c2e061d38"),
                            IsAvaiable = true,
                            MaxCapacity = 12,
                            Name = "Polityczna"
                        });
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyQuickDesk.Entities.Reservation", b =>
                {
                    b.HasOne("MyQuickDesk.Entities.Desk", "Desk")
                        .WithMany("Reservations")
                        .HasForeignKey("DeskId");

                    b.HasOne("MyQuickDesk.Entities.ParkingSpot", "ParkingSpot")
                        .WithMany("Reservations")
                        .HasForeignKey("ParkingSpotId");

                    b.HasOne("MyQuickDesk.Entities.Room", "Room")
                        .WithMany("Reservations")
                        .HasForeignKey("RoomId");

                    b.HasOne("MyQuickDesk.Entities.Space", "Space")
                        .WithMany()
                        .HasForeignKey("SpaceId");

                    b.HasOne("MyQuickDesk.Entities.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserId");

                    b.Navigation("Desk");

                    b.Navigation("ParkingSpot");

                    b.Navigation("Room");

                    b.Navigation("Space");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MyQuickDesk.Entities.Space", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.Navigation("CreatedBy");
                });

            modelBuilder.Entity("MyQuickDesk.Entities.User", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("MyQuickDesk.Entities.Desk", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("MyQuickDesk.Entities.ParkingSpot", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("MyQuickDesk.Entities.Room", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
