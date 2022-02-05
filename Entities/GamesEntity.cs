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
        public string Category { get; set; }
        public string PosterUrl { get; set; }
        public string CoverImgUrl { get; set; }

        public int PlatformId { get; set; }
        public PlatformEntity Platform { get; set; }

    }
}
