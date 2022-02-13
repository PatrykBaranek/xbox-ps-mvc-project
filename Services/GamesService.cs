using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xbox_ps_mvc_project.Database;
using xbox_ps_mvc_project.Entities;
using xbox_ps_mvc_project.Models;

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

        public async Task<AddGameViewModel> AddGame()
        {
            var gameViewModel = new AddGameViewModel()
            {
                Platforms = await _dbContext.Platforms.ToListAsync(),
                Genres = await _dbContext.Genres.ToListAsync(),
            };

            return gameViewModel;
        }

        public async Task<GamesEntity> GameAdded(string title, string description, string posterUrl, string coverImgUrl, int platformSelected, int genreSelected)
        {
            var newGame = new GamesEntity()
            {
                Title = title,
                Description = description,
                PosterUrl = posterUrl,
                CoverImgUrl = coverImgUrl,
                Games_Platforms = new List<Games_Platforms> { new Games_Platforms() { PlatformId = platformSelected } },
                Games_Genres = new List<Games_Genres> { new Games_Genres() { GenreId = genreSelected } }
            };

            

            await _dbContext.AddAsync(newGame);
            await _dbContext.SaveChangesAsync();

            return newGame;
        }
    }
}
