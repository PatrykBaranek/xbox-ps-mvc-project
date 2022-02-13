using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xbox_ps_mvc_project.Entities;

namespace xbox_ps_mvc_project.Models
{
    public class AddGameViewModel
    {
        public GamesEntity Games { get; set; }
        public IEnumerable<PlatformEntity> Platforms { get; set; }
        public IEnumerable<GenresEntity> Genres { get; set; }
    }
}
