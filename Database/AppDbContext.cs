using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xbox_ps_mvc_project.Entities;

namespace xbox_ps_mvc_project.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<GamesEntity> Games { get; set; }
        public DbSet<PlatformEntity> Platforms { get; set; }
        public DbSet<GenresEntity> Genres { get; set; }
        public DbSet<Games_Platforms> Games_Platforms { get; set; }
        public DbSet<Games_Genres> Games_Genres { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Games_Platforms>()
                .HasOne(g => g.Game)
                .WithMany(gp => gp.Games_Platforms)
                .HasForeignKey(gi => gi.GameId);

            modelBuilder.Entity<Games_Platforms>()
                .HasOne(p => p.Platform)
                .WithMany(gp => gp.Games_Platforms)
                .HasForeignKey(pi => pi.PlatformId);

            modelBuilder.Entity<Games_Genres>()
                .HasOne(g => g.Game)
                .WithMany(gg => gg.Games_Genres)
                .HasForeignKey(gi => gi.GameId);

            modelBuilder.Entity<Games_Genres>()
                .HasOne(g => g.Genre)
                .WithMany(gg => gg.Games_Genres)
                .HasForeignKey(gi => gi.GenreId);

            modelBuilder.Entity<GamesEntity>()
                .Property(g => g.Id)
                .IsRequired();

            modelBuilder.Entity<GamesEntity>()
                .Property(g => g.Title)
                .IsRequired()
                .HasMaxLength(50);


            modelBuilder.Entity<GamesEntity>().HasData(
                new GamesEntity { Id = 1, Title = "Dying Light 2", Description = "Action Game", PosterUrl = "https://image.api.playstation.com/vulcan/img/rnd/202106/2908/7aJhOMuJALdBPqZHVy3CgJsg.png", CoverImgUrl = "https://wallpapercrafter.com/desktop/29964-Dying-Light-2-E3-2018-poster-4K.jpg" });

            modelBuilder.Entity<PlatformEntity>()
                .HasData(
                new PlatformEntity() { Id = 1, PlatformName = "PC" },
                new PlatformEntity() { Id = 2, PlatformName = "PS5" },
                new PlatformEntity() { Id = 3, PlatformName = "PS4" },
                new PlatformEntity() { Id = 4, PlatformName = "XBOX_SERIES_X" },
                new PlatformEntity() { Id = 5, PlatformName = "XBOX_SERIES_S" },
                new PlatformEntity() { Id = 6, PlatformName = "XBOX_ONE_X" },
                new PlatformEntity() { Id = 7, PlatformName = "XBOX_ONE_S" }
                );

            modelBuilder.Entity<GenresEntity>()
                .HasData(
                    new GenresEntity { Id = 1, GenreName = "Action" },
                    new GenresEntity { Id = 2, GenreName = "Action role-playing" },
                    new GenresEntity { Id = 3, GenreName = "Casual game" }
                );

            modelBuilder.Entity<Games_Genres>()
                .HasData(
                    new Games_Genres { Id = 1, GameId = 1, GenreId = 1 },
                    new Games_Genres { Id = 2, GameId = 1, GenreId = 2 }
                );

            modelBuilder.Entity<Games_Platforms>()
                .HasData(
                    new Games_Platforms() { Id = 1, GameId = 1, PlatformId = 1 },
                    new Games_Platforms() { Id = 2, GameId = 1, PlatformId = 2 },
                    new Games_Platforms() { Id = 3, GameId = 1, PlatformId = 3 }
                    );
        }
    }
}
