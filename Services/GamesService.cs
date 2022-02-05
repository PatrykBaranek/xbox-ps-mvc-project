using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xbox_ps_mvc_project.Database;
using xbox_ps_mvc_project.Entities;

namespace xbox_ps_mvc_project.Services
{
    public class GamesService : IGamesService
    {
        private readonly AppDbContext _dbContext;
        public GamesService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<GamesEntity>> Index()
        {
            var gamesList = await _dbContext.Games.ToListAsync();

            return gamesList;
        }

        public async Task<GamesEntity> GameDetails(int? id)
        {
            var gamesDetails = await _dbContext.Games.FindAsync(id);

            return gamesDetails;
        }

        public async Task<GamesEntity> GameAdded(string title, string category, string posterUrl, string coverImgUrl)
        {
            var newGame = new GamesEntity()
            {
                Title = title,
                Category = category,
                PosterUrl = posterUrl,
                CoverImgUrl = coverImgUrl
            };

            await _dbContext.AddAsync(newGame);
            await _dbContext.SaveChangesAsync();

            return newGame;
        }
    }
}
