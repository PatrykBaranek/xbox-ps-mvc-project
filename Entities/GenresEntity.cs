using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xbox_ps_mvc_project.Entities
{
    public class GenresEntity
    {
        public int Id { get; set; }
        public string GenreName { get; set; }

        // Navigations Properties

        public List<Games_Genres> Games_Genres { get; set; }
    }
}
