﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using xbox_ps_mvc_project.Database;

#nullable disable

namespace xbox_ps_mvc_project.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220205215534_Init2")]
    partial class Init2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("xbox_ps_mvc_project.Entities.GamesEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CoverImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlatformId")
                        .HasMaxLength(25)
                        .HasColumnType("int");

                    b.Property<string>("PosterUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("PlatformId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Action Game",
                            CoverImgUrl = "https://wallpapercrafter.com/desktop/29964-Dying-Light-2-E3-2018-poster-4K.jpg",
                            Description = "Action Game",
                            PlatformId = 1,
                            PosterUrl = "https://image.api.playstation.com/vulcan/img/rnd/202106/2908/7aJhOMuJALdBPqZHVy3CgJsg.png",
                            Title = "Dying Light 2"
                        });
                });

            modelBuilder.Entity("xbox_ps_mvc_project.Entities.PlatformEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("PlatformName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Platforms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PlatformName = "PS5"
                        },
                        new
                        {
                            Id = 2,
                            PlatformName = "PS4"
                        },
                        new
                        {
                            Id = 3,
                            PlatformName = "XBOX SERIES X"
                        },
                        new
                        {
                            Id = 4,
                            PlatformName = "XBOX SERIES S"
                        },
                        new
                        {
                            Id = 5,
                            PlatformName = "XBOX ONE S"
                        },
                        new
                        {
                            Id = 6,
                            PlatformName = "XBOX ONE X"
                        });
                });

            modelBuilder.Entity("xbox_ps_mvc_project.Entities.GamesEntity", b =>
                {
                    b.HasOne("xbox_ps_mvc_project.Entities.PlatformEntity", "Platform")
                        .WithMany()
                        .HasForeignKey("PlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Platform");
                });
#pragma warning restore 612, 618
        }
    }
}