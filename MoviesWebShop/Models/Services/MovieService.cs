using MoviesWebShop.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoviesWebShop.Models.Repos;

namespace MoviesWebShop.Models.Services
{
    public class MovieService : IMovieService
    {
        IMovieRepo _movieRepo;

        
        public Movie Add(CreateMovieViewModel movie)
        {
            if (string.IsNullOrWhiteSpace(movie.MovieName))
            {
                throw new ArgumentException("Movies name can not be consist of backspace(s)/whitespace(s)");
            }
            Movie newMovie = new Movie()
            {
                MovieName = movie.MovieName,
                Genre = movie.Genre,
                IMDB = movie.IMDB,
                Price = movie.Price
            };

            _movieRepo.Create(newMovie);
            return newMovie;

        }

        public List<Movie> GetAll()
        {
           return  _movieRepo.GetAll();
        }

        public bool Edit(int id, CreateMovieViewModel editmovie)
        {
            Movie movie = _movieRepo.GetById(id);
           
            if (movie !=null)
            {
                movie.MovieName = editmovie.MovieName;
                movie.Genre = editmovie.Genre;
                movie.IMDB = editmovie.IMDB;
                movie.Price = editmovie.Price;
            }

            return _movieRepo.Update(movie);
        }

        public Movie FindById(int id)
        {
            return _movieRepo.GetById(id);
        }

        public void  Remove(int id)
        {
            Movie movieToRemove = _movieRepo.GetById(id);
            if (movieToRemove != null)
            {
                _movieRepo.Delete(movieToRemove);
            }
            
        }

        public List<Movie> Search(string search)
        {
            List<Movie> searchMovie = _movieRepo.GetAll();

            foreach (Movie  item in searchMovie )
            {
                if (item .MovieName .Contains (search, StringComparison.OrdinalIgnoreCase ))
                {
                    searchMovie.Add(item);

                }
                else if (searchMovie .Count ==0)
                {
                    throw new ArgumentException("Can not find what you were looking for.");
                }

            }
            return searchMovie;

        }
    }
}
