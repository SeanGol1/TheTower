using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheTower.Models;

namespace TheTower.Controllers
{
    public class HomeController : Controller
    {
        private readonly TowerContext _context;

        public HomeController(TowerContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            var results = _context.Monster
                .OrderBy(m => m.ChallengeRating)
                .ToList();
            return View(results);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult LevelRoll(int? id)
        {
            int RoomMove = 0;           

            switch (id)
            {
                case 1:
                    RoomMove = -6;
                    break;
                case 2:
                    RoomMove = -5;
                    break;
                case 3:
                    RoomMove = -4;
                    break;
                case 4:
                    RoomMove = -3;
                    break;
                case 5:
                    RoomMove = -2;
                    break;
                case 6:
                    RoomMove = -1;
                    break;
                case 7:
                    RoomMove = 1;
                    break;
                case 8:
                    RoomMove = 2;
                    break;
                case 9:
                    RoomMove = 3;
                    break;
                case 10:
                    RoomMove = 4;
                    break;
                case 11:
                    RoomMove = 5;
                    break;
                case 12:
                    RoomMove = 6;
                    break;
                default:
                    RoomMove = 0;
                    break;
            }


            return View(RoomMove);
        }
    }
}
