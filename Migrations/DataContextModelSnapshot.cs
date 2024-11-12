﻿// <auto-generated />
using System;
using BlazorSSR.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorSSR.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("BlazorSSR.Models.VideoGameModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Publisher")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ReleaseYear")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("VideoGame");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Publisher = "CD Project",
                            ReleaseYear = 2020,
                            Title = "Cyberpunk 2027"
                        },
                        new
                        {
                            Id = 2,
                            Publisher = "FromSoftware",
                            ReleaseYear = 2022,
                            Title = "Elden Ring"
                        },
                        new
                        {
                            Id = 3,
                            Publisher = "Nintendo",
                            ReleaseYear = 1998,
                            Title = "The Legend of Zelda: Ocarina of Time"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
