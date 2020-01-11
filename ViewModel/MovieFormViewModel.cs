using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DreamStream.Models;

namespace DreamStream.ViewModel
{
    public class MovieFormViewModel
    {
        public List<Genre> Genre { get; set; }
        public Movie Movie { get; set; }
        public string Title { get; set; }
    }
}