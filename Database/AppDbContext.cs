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

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GamesEntity>()
                .Property(g => g.Id)
                .IsRequired();

            modelBuilder.Entity<GamesEntity>()
                .Property(g => g.Title)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<GamesEntity>()
                .Property(g => g.PlatformId)
                .IsRequired()
                .HasMaxLength(25);

            modelBuilder.Entity<GamesEntity>()
                .Property(g => g.Category)
                .IsRequired()
                .HasMaxLength(50);


            modelBuilder.Entity<GamesEntity>().HasData(
                new GamesEntity { Id = 1, Title = "Dying Light 2", Description = "Action Game", PosterUrl = "https://image.api.playstation.com/vulcan/img/rnd/202106/2908/7aJhOMuJALdBPqZHVy3CgJsg.png", CoverImgUrl = "https://wallpapercrafter.com/desktop/29964-Dying-Light-2-E3-2018-poster-4K.jpg", Category = "Action Game", PlatformId = 1});

            modelBuilder.Entity<PlatformEntity>()
                .HasData(
                new PlatformEntity() { Id = 1, PlatformName = "PS5" },
                new PlatformEntity() { Id = 2, PlatformName = "PS4" },
                new PlatformEntity() { Id = 3, PlatformName = "XBOX SERIES X" },
                new PlatformEntity() { Id = 4, PlatformName = "XBOX SERIES S" },
                new PlatformEntity() { Id = 5, PlatformName = "XBOX ONE S" },
                new PlatformEntity() { Id = 6, PlatformName = "XBOX ONE X" }
                );
        }
    }
}
