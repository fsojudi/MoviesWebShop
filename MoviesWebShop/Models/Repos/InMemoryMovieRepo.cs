﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebShop.Models.Repos
{
    public class InMemoryMovieRepo : IMovieRepo
    {

        private static List<Movie> movieList = new List<Movie>() ;
        private static int idCounter = 0;


        public Movie Create(Movie movie)
        {
            movie.Id = idCounter++;
            movieList.Add(movie);
            return movie;
        }

        public void  Delete(Movie movie)
        {
            movieList.Remove(movie);
        }

        public List<Movie> GetAll()
        {
            return movieList;
        }

        public Movie GetById(int id)
        {
            Movie movie = null;
            foreach (Movie  thisMovie in movieList )
            {
                if (thisMovie .Id ==id)
                {
                    movie=thisMovie ;
                    break;
                } 
            }
            return movie;
        }

        public bool Update(Movie movie)
        {
            Movie orgMovie = GetById(movie.Id);
            if (orgMovie != null)
            {
                orgMovie.MovieName = movie.MovieName;
                orgMovie.Genre = movie.Genre;
                orgMovie.IMDB = movie.IMDB;
                orgMovie.Price = movie.Price;

                return true;

            }
            else
                return false;
        }
    }
}
