using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebShop.Controllers
{
    public class MoviesController : Controller
    {
        static List<string[]> MoviesStorage;
        
        
        public MoviesController()
        {
            MoviesStorage = new List<string[]>();
            string[] Seven = new string[] { "Seven", "Crime, Thriller", "8.6", "60" };
            string[] Jocker = new string[] { "Jocker", "Crime, Thriller", "8.4", "49" };
            string[] Shawshank = new string[] { "The Shawshank Redemption", "mystery , prison ", "9.3", "39" };
            string[]  Godfather = new string[] { "The Godfather", "Crime, Thriller", "9.2", "39" };
            MoviesStorage.Add(Seven);
            MoviesStorage.Add(Jocker);
            MoviesStorage.Add(Shawshank);
            MoviesStorage.Add(Godfather);


        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Movies = MoviesStorage;
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
