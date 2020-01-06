using DreamStream.Models;
using DreamStream.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DreamStream.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = new List<Movie>()
            {
                new Movie{Name="Wall-e", Id= 1},
                new Movie{Name="Shrek", Id=2}
            };
            var viewModel = new MovieViewModel
            {
                Movie = movies
            };
            return View(viewModel);
        }
    }
}