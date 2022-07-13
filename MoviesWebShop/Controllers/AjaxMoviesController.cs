using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoviesWebShop.Models;
using MoviesWebShop.Models.Repos;
using MoviesWebShop.Models.Services;

namespace MoviesWebShop.Controllers
{
    public class AjaxMoviesController : Controller
    {
        IMovieService _movieService;

        //private readonly ICountryService _countryService;
        public AjaxMoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SpaMovieList()
        {
            return PartialView("_SpaMovieList", _movieService.GetAll());
        }

        public IActionResult SpaMovieDetails(int id)
        {
            Movie  movie = _movieService.FindById(id);
            if (movie  == null)
            {
                return NotFound();
            }
            return PartialView("_SpaMovieDetails", movie );

        }
        public IActionResult SpaMovieRow(int id)
        {
            Movie  movie = _movieService.FindById(id);

            if (movie  == null)
            {
                return NotFound();
            }

            return PartialView("_SpaMovieRow", movie);
        }
        public IActionResult SpaAjaxDelete(int id)
        {
            Movie  movie = _movieService.FindById(id);
            if (movie  != null)
            {
                _movieService.Remove(id);
                return PartialView("_SpaMovieList", _movieService.GetAll());
            }
            return NotFound();
        }
    }
}