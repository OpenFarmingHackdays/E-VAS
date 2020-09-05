﻿// <auto-generated />
using System;
using E_VAS.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace E_VAS.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200905113440_AddGvePlaceModel")]
    partial class AddGvePlaceModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("E_VAS.Data.Models.GveLocationModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("GveId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<float>("Latitude")
                        .HasColumnType("float");

                    b.Property<string>("LocationCategory")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("Longitude")
                        .HasColumnType("float");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("GveId");

                    b.ToTable("GveLocationModel");
                });

            modelBuilder.Entity("E_VAS.Data.Models.GveModel", b =>
                {
                    b.Property<string>("GveId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("CategoryId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TvdOhrmarkennummer")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("GveId");

                    b.HasIndex("TvdOhrmarkennummer");

                    b.ToTable("GveModel");
                });

            modelBuilder.Entity("E_VAS.Data.Models.GvePlaceModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("GvePlaceModel");
                });

            modelBuilder.Entity("E_VAS.Data.Models.GvePlacePointModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("GvePlaceModelId")
                        .HasColumnType("int");

                    b.Property<float>("Latitude")
                        .HasColumnType("float");

                    b.Property<float>("Longitude")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("GvePlaceModelId");

                    b.ToTable("GvePlacePointModel");
                });

            modelBuilder.Entity("E_VAS.Data.Models.TvdModel", b =>
                {
                    b.Property<string>("Ohrmarkennummer")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Abgangsdatum")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Alter")
                        .HasColumnType("int");

                    b.Property<string>("BLZ_Status")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("BVDStatus")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Erstkalbung")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Folgebetrieb")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("Geburtsbetrieb")
                        .HasColumnType("int");

                    b.Property<string>("Geburtsdatum")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Geschlecht")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Gltigab")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Herkunftsbetrieb")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Labelmeldung")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LetzteAbkalbung")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LetzteGanzjahrestierhaltung")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Mutter_Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Mutter_OM")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Mutter_Rasse")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nutzungsart")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Rasse")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Tiergeschichte")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Todesdatum")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Vater_Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Vater_OM")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Vater_Rasse")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VorherigeNutzungsart")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Zugangsdatum")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Ohrmarkennummer");

                    b.ToTable("TvdModel");
                });

            modelBuilder.Entity("E_VAS.Data.Models.GveLocationModel", b =>
                {
                    b.HasOne("E_VAS.Data.Models.GveModel", "Gve")
                        .WithMany()
                        .HasForeignKey("GveId");
                });

            modelBuilder.Entity("E_VAS.Data.Models.GveModel", b =>
                {
                    b.HasOne("E_VAS.Data.Models.TvdModel", "Tvd")
                        .WithMany()
                        .HasForeignKey("TvdOhrmarkennummer");
                });

            modelBuilder.Entity("E_VAS.Data.Models.GvePlacePointModel", b =>
                {
                    b.HasOne("E_VAS.Data.Models.GvePlaceModel", null)
                        .WithMany("Points")
                        .HasForeignKey("GvePlaceModelId");
                });
#pragma warning restore 612, 618
        }
    }
}
