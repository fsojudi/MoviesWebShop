using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebShop.Models
{
    
    public class OldMovieService
    {
        static List<string[]> MoviesStorage;
        static List<string> genreStorage;

        public OldMovieService ()
        {
            if (MoviesStorage == null)
            {
                MoviesStorage = new List<string[]>();
                string[] Seven = new string[] { "Seven", "Crime, Thriller", "8.6", "60" };
                string[] Jocker = new string[] { "Jocker", "Crime, Thriller", "8.4", "49" };
                string[] Shawshank = new string[] { "The Shawshank Redemption", "mystery , prison ", "9.3", "39" };
                string[] Godfather = new string[] { "The Godfather", "Crime, Thriller", "9.2", "39" };
                MoviesStorage.Add(Seven);
                MoviesStorage.Add(Jocker);
                MoviesStorage.Add(Shawshank);
                MoviesStorage.Add(Godfather);


                genreStorage = new List<string>();
                genreStorage.Add("Action");
                genreStorage.Add("Crime");
                genreStorage.Add("Drama");
                genreStorage.Add("Comedy");
                genreStorage.Add("Horror");
                genreStorage.Add("Sci-Fi/Fantasy");
                genreStorage.Add(" War Drama");
            }

        }

        public List<string[]> GetMovies()
        {
            return MoviesStorage;
        }

        public List <string > GetGenre()
        {
            return genreStorage;
        }

        public void Create(string movieName, string genre, String iMDB, String price)
        {
            if (string.IsNullOrEmpty(movieName))
            {
                throw new ArgumentException($"'{nameof(movieName)}' cannot be null or empty.", nameof(movieName));
            }

            if (string.IsNullOrEmpty(genre))
            {
                throw new ArgumentException($"'{nameof(genre)}' cannot be null or empty.", nameof(genre));
            }

            if (string.IsNullOrEmpty(iMDB))
            {
                throw new ArgumentException($"'{nameof(iMDB)}' cannot be null or empty.", nameof(iMDB));
            }

            if (string.IsNullOrEmpty(price))
            {
                throw new ArgumentException($"'{nameof(price)}' cannot be null or empty.", nameof(price));
            }

            if (!genreStorage .Contains (genre))
            {
                genreStorage.Add(genre);
            }

            MoviesStorage.Add(new string[] { movieName, genre, iMDB, price });
        }





    }
}
