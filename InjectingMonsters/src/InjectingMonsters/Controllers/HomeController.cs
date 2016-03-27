using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using InjectingMonsters.Services;

namespace InjectingMonsters.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMonsterService _monsterService;

        public HomeController(IMonsterService monsterService)
        {
            _monsterService = monsterService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            ViewBag.Monster = _monsterService.GetMonster();
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
