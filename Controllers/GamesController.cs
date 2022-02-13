using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xbox_ps_mvc_project.Database;
using xbox_ps_mvc_project.Entities;
using xbox_ps_mvc_project.Services;

namespace xbox_ps_mvc_project.Controllers
{
    public class GamesController : Controller
    {
        private readonly IGamesService _gamesService;

        public GamesController(IGamesService gamesService)
        {
            _gamesService = gamesService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var gamesList = await _gamesService.Index();

            return View(gamesList);
        }

        [HttpGet]
        public async Task<IActionResult> GameDetails(int? id)
        {
            var gameDetails = await _gamesService.GameDetails(id);

            if (id == null || gameDetails == null)
            {
                return NotFound();
            }

            return View(gameDetails);
        }

        [HttpGet]
        public async Task<IActionResult> AddGame()
        {
            var gameViewModel = await _gamesService.AddGame();

            return View(gameViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> GameAdded([FromForm] string title, [FromForm] string description, [FromForm] string posterUrl, [FromForm] string coverImgUrl, [FromForm] int platformSelected, [FromForm] int genreSelected)
        {
            var newGame = await _gamesService.GameAdded(title, description, posterUrl, coverImgUrl, platformSelected, genreSelected);

            return View(newGame);
        }

    }
}
