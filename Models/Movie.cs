using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DreamStream.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Display(Name="Movie Name")]
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        [Display(Name="Release Date")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name="Number in Stock")]
        public int NumberInStock  { get; set; }
    }
}