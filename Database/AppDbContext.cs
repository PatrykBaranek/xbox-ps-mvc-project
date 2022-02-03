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
    }
}
