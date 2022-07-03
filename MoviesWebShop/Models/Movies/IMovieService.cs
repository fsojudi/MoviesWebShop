using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebShop.Models.Movies
{
    interface IMovieService
    {
         List<Movie > GetMovies();
        List<string> GetGenre();
        Movie CreateMovie(CreateMovieViewModel creatMovie);

    }
}
