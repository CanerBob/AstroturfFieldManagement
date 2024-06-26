﻿// <auto-generated />
using System;
using AstroturfField.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AstroturfField.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AstroturfField.Entity.Entities.ArtificialTurf", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("AstroturfFieldOwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AstroturfFieldOwnerId");

                    b.HasIndex("CityId");

                    b.ToTable("ArtificialTurves");

                    b.HasData(
                        new
                        {
                            Id = new Guid("164d108a-cbb3-4e5e-9b47-a43738d2c5b1"),
                            Adress = "Sanayinin Girişi",
                            AstroturfFieldOwnerId = new Guid("58b71aa4-80ed-4d76-a062-8cee2bbe4928"),
                            CityId = new Guid("c3d8a7f4-5137-4bd3-a52e-4db8ed951fd8"),
                            CreatedDate = new DateTime(2024, 7, 1, 12, 5, 53, 34, DateTimeKind.Utc).AddTicks(6169),
                            District = "Merkez",
                            IsActive = true,
                            Name = "Gökkaya"
                        },
                        new
                        {
                            Id = new Guid("d7209b6c-1b0a-49f4-b181-fc155585a948"),
                            Adress = "Sanayinin Sonu",
                            AstroturfFieldOwnerId = new Guid("829820ed-d1ff-4995-b7bf-3ad6983ff0cd"),
                            CityId = new Guid("afb580e1-ab0d-40d1-a26e-8fb443ddac76"),
                            CreatedDate = new DateTime(2024, 7, 1, 12, 5, 53, 34, DateTimeKind.Utc).AddTicks(6176),
                            District = "Merkez",
                            IsActive = true,
                            Name = "Kardeşler"
                        });
                });

            modelBuilder.Entity("AstroturfField.Entity.Entities.AstroturfFieldOwner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ArtificialTurfId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AstroturfFieldOwners");

                    b.HasData(
                        new
                        {
                            Id = new Guid("58b71aa4-80ed-4d76-a062-8cee2bbe4928"),
                            ArtificialTurfId = new Guid("164d108a-cbb3-4e5e-9b47-a43738d2c5b1"),
                            FullName = "Caner Bayraktar",
                            IsActive = true,
                            PhoneNumber = "1234567890"
                        },
                        new
                        {
                            Id = new Guid("829820ed-d1ff-4995-b7bf-3ad6983ff0cd"),
                            ArtificialTurfId = new Guid("d7209b6c-1b0a-49f4-b181-fc155585a948"),
                            FullName = "Caner Bayraktar",
                            IsActive = true,
                            PhoneNumber = "1234567890"
                        });
                });

            modelBuilder.Entity("AstroturfField.Entity.Entities.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ArtificialTurfFieldId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c3d8a7f4-5137-4bd3-a52e-4db8ed951fd8"),
                            ArtificialTurfFieldId = new Guid("164d108a-cbb3-4e5e-9b47-a43738d2c5b1"),
                            Name = "Bilecik"
                        },
                        new
                        {
                            Id = new Guid("afb580e1-ab0d-40d1-a26e-8fb443ddac76"),
                            ArtificialTurfFieldId = new Guid("4b90104a-5d36-44c6-8261-9c59b1653ff4"),
                            Name = "Eskişehir"
                        });
                });

            modelBuilder.Entity("AstroturfField.Entity.Entities.FootbalEquipment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ReservationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.ToTable("FootbalEquipments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5e8f0707-a9fc-4e1f-a4d9-7966ad1d74bd"),
                            IsActive = true,
                            Name = "Krampon"
                        },
                        new
                        {
                            Id = new Guid("7fbdfa79-100f-4b0c-88d6-1ca94bbc139b"),
                            IsActive = true,
                            Name = "Kaleci Eldiveni"
                        });
                });

            modelBuilder.Entity("AstroturfField.Entity.Entities.Reservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ArtificialTurfId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FootbalEquipmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("MatchTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeRange")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ArtificialTurfId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("AstroturfField.Entity.Entities.ArtificialTurf", b =>
                {
                    b.HasOne("AstroturfField.Entity.Entities.AstroturfFieldOwner", "AstroturfFieldOwner")
                        .WithMany("ArtificialTurves")
                        .HasForeignKey("AstroturfFieldOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AstroturfField.Entity.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AstroturfFieldOwner");

                    b.Navigation("City");
                });

            modelBuilder.Entity("AstroturfField.Entity.Entities.FootbalEquipment", b =>
                {
                    b.HasOne("AstroturfField.Entity.Entities.Reservation", null)
                        .WithMany("FootbalEquipment")
                        .HasForeignKey("ReservationId");
                });

            modelBuilder.Entity("AstroturfField.Entity.Entities.Reservation", b =>
                {
                    b.HasOne("AstroturfField.Entity.Entities.ArtificialTurf", "ArtificialTurf")
                        .WithMany()
                        .HasForeignKey("ArtificialTurfId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ArtificialTurf");
                });

            modelBuilder.Entity("AstroturfField.Entity.Entities.AstroturfFieldOwner", b =>
                {
                    b.Navigation("ArtificialTurves");
                });

            modelBuilder.Entity("AstroturfField.Entity.Entities.Reservation", b =>
                {
                    b.Navigation("FootbalEquipment");
                });
#pragma warning restore 612, 618
        }
    }
}
