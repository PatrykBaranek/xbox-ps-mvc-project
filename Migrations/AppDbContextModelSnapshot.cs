﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using xbox_ps_mvc_project.Database;

#nullable disable

namespace xbox_ps_mvc_project.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("xbox_ps_mvc_project.Entities.Games_Genres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("GenreId");

                    b.ToTable("Games_Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GameId = 1,
                            GenreId = 1
                        },
                        new
                        {
                            Id = 2,
                            GameId = 1,
                            GenreId = 2
                        });
                });

            modelBuilder.Entity("xbox_ps_mvc_project.Entities.Games_Platforms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("PlatformId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("PlatformId");

                    b.ToTable("Games_Platforms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GameId = 1,
                            PlatformId = 1
                        },
                        new
                        {
                            Id = 2,
                            GameId = 1,
                            PlatformId = 2
                        },
                        new
                        {
                            Id = 3,
                            GameId = 1,
                            PlatformId = 3
                        });
                });

            modelBuilder.Entity("xbox_ps_mvc_project.Entities.GamesEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CoverImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PosterUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CoverImgUrl = "https://wallpapercrafter.com/desktop/29964-Dying-Light-2-E3-2018-poster-4K.jpg",
                            Description = "Action Game",
                            PosterUrl = "https://image.api.playstation.com/vulcan/img/rnd/202106/2908/7aJhOMuJALdBPqZHVy3CgJsg.png",
                            Title = "Dying Light 2"
                        });
                });

            modelBuilder.Entity("xbox_ps_mvc_project.Entities.GenresEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("GenreName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GenreName = "Action"
                        },
                        new
                        {
                            Id = 2,
                            GenreName = "Action role-playing"
                        },
                        new
                        {
                            Id = 3,
                            GenreName = "Casual game"
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
                            PlatformName = "PC"
                        },
                        new
                        {
                            Id = 2,
                            PlatformName = "PS5"
                        },
                        new
                        {
                            Id = 3,
                            PlatformName = "PS4"
                        },
                        new
                        {
                            Id = 4,
                            PlatformName = "XBOX_SERIES_X"
                        },
                        new
                        {
                            Id = 5,
                            PlatformName = "XBOX_SERIES_S"
                        },
                        new
                        {
                            Id = 6,
                            PlatformName = "XBOX_ONE_X"
                        },
                        new
                        {
                            Id = 7,
                            PlatformName = "XBOX_ONE_S"
                        });
                });

            modelBuilder.Entity("xbox_ps_mvc_project.Entities.Games_Genres", b =>
                {
                    b.HasOne("xbox_ps_mvc_project.Entities.GamesEntity", "Game")
                        .WithMany("Games_Genres")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("xbox_ps_mvc_project.Entities.GenresEntity", "Genre")
                        .WithMany("Games_Genres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("xbox_ps_mvc_project.Entities.Games_Platforms", b =>
                {
                    b.HasOne("xbox_ps_mvc_project.Entities.GamesEntity", "Game")
                        .WithMany("Games_Platforms")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("xbox_ps_mvc_project.Entities.PlatformEntity", "Platform")
                        .WithMany("Games_Platforms")
                        .HasForeignKey("PlatformId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Platform");
                });

            modelBuilder.Entity("xbox_ps_mvc_project.Entities.GamesEntity", b =>
                {
                    b.Navigation("Games_Genres");

                    b.Navigation("Games_Platforms");
                });

            modelBuilder.Entity("xbox_ps_mvc_project.Entities.GenresEntity", b =>
                {
                    b.Navigation("Games_Genres");
                });

            modelBuilder.Entity("xbox_ps_mvc_project.Entities.PlatformEntity", b =>
                {
                    b.Navigation("Games_Platforms");
                });
#pragma warning restore 612, 618
        }
    }
}
