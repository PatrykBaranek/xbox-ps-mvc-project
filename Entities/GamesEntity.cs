using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xbox_ps_mvc_project.Entities
{
    public class GamesEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PosterUrl { get; set; }
        public string CoverImgUrl { get; set; }

        // Navigations Properties
        public List<Games_Platforms> Games_Platforms { get; set; }

        public List<Games_Genres> Games_Genres { get; set; }
    }
}