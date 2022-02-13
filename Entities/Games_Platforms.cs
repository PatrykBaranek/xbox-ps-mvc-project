using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xbox_ps_mvc_project.Entities
{
    public class Games_Platforms
    {
        public int Id { get; set; }

        public int GameId { get; set; }
        public GamesEntity Game { get; set; }


        public int PlatformId { get; set; }
        public PlatformEntity Platform { get; set; }
    }
}
