﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parcels.Models;

#nullable disable

namespace Parcels.Migrations
{
    [DbContext(typeof(ParcelsContext))]
    partial class ParcelsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Parcels.Models.Package", b =>
                {
                    b.Property<int>("PackageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("Height")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Length")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.Property<int?>("Weight")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Width")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("PackageId");

                    b.HasIndex("SenderId");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("Parcels.Models.PackageTag", b =>
                {
                    b.Property<int>("PackageTagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("PackageId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("PackageTagId");

                    b.HasIndex("PackageId");

                    b.HasIndex("TagId");

                    b.ToTable("PackageTags");
                });

            modelBuilder.Entity("Parcels.Models.Sender", b =>
                {
                    b.Property<int>("SenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("SenderId");

                    b.ToTable("Senders");
                });

            modelBuilder.Entity("Parcels.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Parcels.Models.Package", b =>
                {
                    b.HasOne("Parcels.Models.Sender", "Sender")
                        .WithMany("Packages")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("Parcels.Models.PackageTag", b =>
                {
                    b.HasOne("Parcels.Models.Package", "Package")
                        .WithMany("JoinEntities")
                        .HasForeignKey("PackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Parcels.Models.Tag", "Tag")
                        .WithMany("JoinEntities")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Package");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("Parcels.Models.Package", b =>
                {
                    b.Navigation("JoinEntities");
                });

            modelBuilder.Entity("Parcels.Models.Sender", b =>
                {
                    b.Navigation("Packages");
                });

            modelBuilder.Entity("Parcels.Models.Tag", b =>
                {
                    b.Navigation("JoinEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
