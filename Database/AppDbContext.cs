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

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GamesEntity>()
                .Property(x => x.Id)
                .IsRequired();

            modelBuilder.Entity<GamesEntity>().HasData(
                new GamesEntity {Id = 1, Title = "Dying Light 2", Description = "Zombie Game", PosterUrl = "https://image.api.playstation.com/vulcan/img/rnd/202106/2908/7aJhOMuJALdBPqZHVy3CgJsg.png", CoverImgUrl = "https://wallpapercrafter.com/desktop/29964-Dying-Light-2-E3-2018-poster-4K.jpg" }); 
        }
    }
}
