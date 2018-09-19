﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OVE.Service.ImageTiles.DbContexts;

namespace OVE.Service.ImageTiles.Migrations
{
    [DbContext(typeof(ImageFileContext))]
    partial class ImageFileContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932");

            modelBuilder.Entity("OVE.Service.ImageTiles.Models.ImageFileModel", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Filename")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Height");

                    b.Property<string>("Project")
                        .IsRequired();

                    b.Property<int>("Width");

                    b.HasKey("Id");

                    b.ToTable("ImageFiles");
                });
#pragma warning restore 612, 618
        }
    }
}