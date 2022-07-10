using MoviesWebShop.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebShop.Models.Services
{
    public class OldMovieService2 
    {
        static int idCounter = 0;
        static List<Movie> movieStorage = new List<Movie>();
        static List<string> genreStorage = new List<string>();

        public OldMovieService2()
        {

            if (genreStorage .Count == 0)
            {
                genreStorage.Add("Action");
                genreStorage.Add("Crime");
                genreStorage.Add("Drama");
                genreStorage.Add("Comedy");
                genreStorage.Add("Horror");
                genreStorage.Add("Sci-Fi/Fantasy");
                genreStorage.Add(" War Drama");

   
                movieStorage.Add(new Movie() { Id = ++idCounter, MovieName = "Seven", Genre = "Crime", IMDB = 8.6, Price = 60 });
                movieStorage.Add(new Movie() { Id = ++idCounter, MovieName = "Jocker", Genre = "Crime, Thriller", IMDB = 8.4, Price = 49 });
                movieStorage.Add(new Movie() { Id = ++idCounter, MovieName = "The Shawshank Redemption", Genre = "mystery,prison", IMDB = 9.3, Price = 39 });
                movieStorage.Add(new Movie() { Id = ++idCounter, MovieName = "The Godfather", Genre = "Crime, Thriller", IMDB = 9.2, Price = 39 });

            }
        }
        public Movie CreateMovie(CreateMovieViewModel creatMovie)
        {
            Movie newMovie=new Movie() { Id = ++idCounter, MovieName =creatMovie .MovieName , Genre = creatMovie .Genre , IMDB = creatMovie .IMDB , Price = creatMovie .Price };
            movieStorage.Add(newMovie);
            return newMovie;
        }
        

        public Movie GetById(int id) 
        {
        foreach (Movie  movie  in movieStorage)
        {
                if (movie .Id==id)
                {
                    return movie;
                }

                
        }
            return null;
        }

        public List<string> GetGenre()
        {
            return genreStorage;
        }

        public List<Movie> GetMovies()
        {
            return movieStorage;
        }
    }
}
