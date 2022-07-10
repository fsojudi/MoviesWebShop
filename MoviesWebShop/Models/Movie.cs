using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebShop.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
       
        public string Genre { get; set; }
        public double  IMDB { get; set; }
        public int Price { get; set; }

    }
}
