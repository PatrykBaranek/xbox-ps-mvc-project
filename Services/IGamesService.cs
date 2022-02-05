using xbox_ps_mvc_project.Entities;

namespace xbox_ps_mvc_project.Services
{
    public interface IGamesService
    {
        Task<IEnumerable<GamesEntity>> Index();
        Task<GamesEntity> GameDetails(int? id);
        Task<GamesEntity> GameAdded(string title, string category, string posterUrl, string coverImgUrl);
    }
}
