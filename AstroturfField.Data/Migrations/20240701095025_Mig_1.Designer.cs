﻿// <auto-generated />
using System;
using AstroturfField.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AstroturfField.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240701095025_Mig_1")]
    partial class Mig_1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<Guid?>("AstroturfFieldOwnerId")
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

                    b.ToTable("ArtificialTurves");
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
                    b.HasOne("AstroturfField.Entity.Entities.AstroturfFieldOwner", null)
                        .WithMany("ArtificialTurves")
                        .HasForeignKey("AstroturfFieldOwnerId");
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
