using Microsoft.AspNetCore.Mvc;
using MoviesWebShop.Models;
using MoviesWebShop.Models.Repos;
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
        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
           
        }

        [HttpGet]
        public IActionResult Index()
        {
           
            return View(_movieService.GetAll());
        }

        public IActionResult Ajax()
        {

            return View();
        }

        public IActionResult GetMovie()
        {

            return PartialView(_movieService.GetAll());
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
            if (ModelState.IsValid)
            {
                _movieService.Add(createMovie);
                return RedirectToAction("Index");
            }

            //createMovie.GenreList =_movieService.GetGenre();

            return View(createMovie);
        }




 //**********************************// AJAX //*******************************************//
            public IActionResult PartialViewMovies()
            {
                return PartialView("_MovieList", _movieService.GetAll());
            }
            [HttpPost]
            public IActionResult PartialViewDetails(int id)
            {
                Movie  movie = _movieService.FindById(id);
                if (movie != null)
                {
                    return PartialView("_MovieDetails", movie);
                }
                return NotFound();
            }
            public IActionResult AjaxDelete(int id)
            {
                Movie  movie = _movieService.FindById(id);
                if (movie != null)
                {
                    _movieService.Remove(id);
                    return PartialView("_MovieList", _movieService.GetAll());
                }
                return NotFound();
            }




        }
    }

