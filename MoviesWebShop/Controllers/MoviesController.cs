using Microsoft.AspNetCore.Mvc;
using MoviesWebShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebShop.Controllers
{
    public class MoviesController : Controller
    {

        MovieService _movieService;
        public MoviesController()
        {
            _movieService = new MovieService() ;

        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Movies = _movieService.GetMovies();
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Genres = _movieService.GetGenre();
            return View();
        }

        [HttpPost]
        public IActionResult Create( string movieName, string genre, string iMDB,string price)
        {
            try
            {
                _movieService.Create(movieName, genre, iMDB, price);

                return RedirectToAction("Index");

            }
            catch (ArgumentException exeptionData)
            {

                ViewBag.ExceptionMsg = exeptionData.Message; 
            }

            ViewBag.MovieName = movieName;
            ViewBag.Genre = genre;
            ViewBag.IMDB = iMDB;
            ViewBag.Price = price;
            ViewBag.Genres = _movieService.GetGenre();
            return View();


            
        }
    }
}
