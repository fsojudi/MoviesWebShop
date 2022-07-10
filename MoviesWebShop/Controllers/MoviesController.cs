using Microsoft.AspNetCore.Mvc;
using MoviesWebShop.Models;
using MoviesWebShop.Models.Services;
using MoviesWebShop.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebShop.Controllers
{
    public class MoviesController : Controller
    {

        IMovieService _movieService;
        public MoviesController()
        {
            _movieService = new MovieService() ;

        }

        [HttpGet]
        public IActionResult Index()
        {
           
            return View(_movieService.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            CreateMovieViewModel createMovie = new CreateMovieViewModel() ;
            //createMovie.GenreList = _movieService.GetGenre();
            return View(createMovie );
        }

        [HttpPost]
        public IActionResult Create(CreateMovieViewModel createMovie)
        {
            if (ModelState .IsValid )
            {
                _movieService.Add(createMovie);
                return RedirectToAction("Index"); 
            }

            //createMovie.GenreList =_movieService.GetGenre();

            return View(createMovie);
            


            
        }
    }
}
