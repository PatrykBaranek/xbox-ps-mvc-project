using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xbox_ps_mvc_project.Controllers
{
    public class GamesController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
