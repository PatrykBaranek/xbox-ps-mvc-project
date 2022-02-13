using xbox_ps_mvc_project.Entities;
using xbox_ps_mvc_project.Models;

namespace xbox_ps_mvc_project.Services
{
    public interface IGamesService
    {
        Task<IEnumerable<GamesEntity>> Index();
        Task<GamesEntity> GameDetails(int? id);
        Task<AddGameViewModel> AddGame();
        Task<GamesEntity> GameAdded(string title,string description, string posterUrl, string coverImgUrl, int platformSelected, int genreSelected);
    }
}
