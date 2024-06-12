﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NZWalks.API.Data;

#nullable disable

namespace NZWalks.API.Migrations
{
    [DbContext(typeof(NZWalksDbContext))]
    [Migration("20240612131242_Seeding Data For Difficulties and Regions")]
    partial class SeedingDataForDifficultiesandRegions
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NZWalks.API.Models.Domain.Difficulty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Difficulties");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fe58ef6d-3957-42bd-84eb-fb5984250b98"),
                            Name = "Easy"
                        },
                        new
                        {
                            Id = new Guid("529e8a1e-eb80-451a-a5a4-5a9a89f88350"),
                            Name = "Medium"
                        },
                        new
                        {
                            Id = new Guid("2cc0f7e6-7916-47fc-902d-3892666ecfa4"),
                            Name = "Hard"
                        });
                });

            modelBuilder.Entity("NZWalks.API.Models.Domain.Region", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegionImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3b0fe77b-2431-4471-a813-3ed206b78e8f"),
                            Code = "AKL",
                            Name = "Auckland",
                            RegionImageUrl = "https://www.google.com/imgres?q=3d%20images%20hd&imgurl=https%3A%2F%2Fwallpapers.com%2Fimages%2Fhd%2F3d-hd-tree-cup-miniature-3afg373o0vwa5dxq.jpg&imgrefurl=https%3A%2F%2Fwallpapers.com%2F3d-hd&docid=a3PZgobyCyc-JM&tbnid=d1p9NgPNR71PHM&vet=12ahUKEwjxquydkNaGAxV4d2wGHadUB3YQM3oECBUQAA..i&w=1920&h=1200&hcb=2&ved=2ahUKEwjxquydkNaGAxV4d2wGHadUB3YQM3oECBUQAA"
                        },
                        new
                        {
                            Id = new Guid("5199f117-ad9f-469f-91c8-3311b9b1f84d"),
                            Code = "NTL",
                            Name = "Northland"
                        },
                        new
                        {
                            Id = new Guid("a102235e-04f6-489b-bc45-27b6e0a36387"),
                            Code = "BOP",
                            Name = "bay Of Plenty"
                        },
                        new
                        {
                            Id = new Guid("69c60c7a-cd16-4b36-bc2f-3fba45f02e89"),
                            Code = "WGN",
                            Name = "Wellington",
                            RegionImageUrl = "https://www.google.com/imgres?q=3d%20images%20hd&imgurl=https%3A%2F%2Fimg.freepik.com%2Ffree-photo%2Fcloseup-textural-bright-exotic-flowers-generative-al_169016-28578.jpg&imgrefurl=https%3A%2F%2Fwww.freepik.com%2Ffree-photos-vectors%2F3d-wallpaper&docid=m7OpOqkGrqw0IM&tbnid=XV01SKEeY5qrkM&vet=12ahUKEwjxquydkNaGAxV4d2wGHadUB3YQM3oECFsQAA..i&w=626&h=358&hcb=2&ved=2ahUKEwjxquydkNaGAxV4d2wGHadUB3YQM3oECFsQAA"
                        },
                        new
                        {
                            Id = new Guid("cdd6fb31-8e2f-4bb9-a3ab-544178efd622"),
                            Code = "NSN",
                            Name = "Nelson",
                            RegionImageUrl = "https://www.google.com/imgres?q=3d%20images%20hd&imgurl=https%3A%2F%2Fc4.wallpaperflare.com%2Fwallpaper%2F93%2F298%2F371%2Fsteampunk-3d-artwork-eyes-wallpaper-preview.jpg&imgrefurl=https%3A%2F%2Fwww.wallpaperflare.com%2Fsearch%3Fwallpaper%3D3d%2Bart&docid=Nx3ImR4lAPHgUM&tbnid=p85aC4PAqYTWgM&vet=12ahUKEwjxquydkNaGAxV4d2wGHadUB3YQM3oECFgQAA..i&w=728&h=410&hcb=2&ved=2ahUKEwjxquydkNaGAxV4d2wGHadUB3YQM3oECFgQAA"
                        },
                        new
                        {
                            Id = new Guid("5c237922-5fdc-4789-ae75-e2eadaa8269b"),
                            Code = "STL",
                            Name = "Southland"
                        });
                });

            modelBuilder.Entity("NZWalks.API.Models.Domain.Walk", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DifficultyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("LengthInKm")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RegionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WalkImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DifficultyId");

                    b.HasIndex("RegionId");

                    b.ToTable("Walks");
                });

            modelBuilder.Entity("NZWalks.API.Models.Domain.Walk", b =>
                {
                    b.HasOne("NZWalks.API.Models.Domain.Difficulty", "Difficulty")
                        .WithMany()
                        .HasForeignKey("DifficultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NZWalks.API.Models.Domain.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Difficulty");

                    b.Navigation("Region");
                });
#pragma warning restore 612, 618
        }
    }
}
