using MoviesWebShop.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebShop.Models.Services
{
    interface IMovieService
    {
        Movie Add(CreateMovieViewModel movie);
        List<Movie> GetAll();
        List<Movie> Search(string search);
        Movie FindById(int id);
        bool Edit(int id, CreateMovieViewModel editmovie);
        void Remove(int id);
    }
}
