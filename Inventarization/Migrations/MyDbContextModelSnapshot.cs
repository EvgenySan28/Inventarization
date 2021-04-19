﻿// <auto-generated />
using System;
using Inventarization.Data.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Inventarization.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("Inventarization.Data.DB.entities.Nomenclature", b =>
                {
                    b.Property<int>("NomenclatureID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("RoomID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Сondition")
                        .HasColumnType("TEXT");

                    b.HasKey("NomenclatureID");

                    b.HasIndex("RoomID");

                    b.ToTable("Nomenclatures");
                });

            modelBuilder.Entity("Inventarization.Data.DB.entities.Responsible", b =>
                {
                    b.Property<int>("ResponsibleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("ResponsibleID");

                    b.ToTable("Responsibles");
                });

            modelBuilder.Entity("Inventarization.Data.DB.entities.Room", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ResponsibleID")
                        .HasColumnType("INTEGER");

                    b.HasKey("RoomID");

                    b.HasIndex("ResponsibleID");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Inventarization.Data.DB.entities.Nomenclature", b =>
                {
                    b.HasOne("Inventarization.Data.DB.entities.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomID");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Inventarization.Data.DB.entities.Room", b =>
                {
                    b.HasOne("Inventarization.Data.DB.entities.Responsible", "Responsible")
                        .WithMany()
                        .HasForeignKey("ResponsibleID");

                    b.Navigation("Responsible");
                });
#pragma warning restore 612, 618
        }
    }
}