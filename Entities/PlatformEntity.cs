using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xbox_ps_mvc_project.Entities
{
    public class PlatformEntity
    {
        public int Id { get; set; }
        public string PlatformName { get; set; }

        // Navigations Properties

        public List<Games_Platforms> Games_Platforms { get; set; }

    }

    
}
