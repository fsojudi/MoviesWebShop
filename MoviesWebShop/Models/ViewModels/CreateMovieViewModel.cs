using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebShop.Models.ViewModels
{
    public class CreateMovieViewModel
    {
        [Required]
        public string MovieName { get; set; }

        [Required]
        public string Genre { get; set; }
      
        [Required]
        [Range(0,10)]
        public double IMDB { get; set; }

        [Required]
        [Range (0,int.MaxValue)]
        public int Price { get; set; }

        public List<string> GenreList { get; set; }

    }
}
