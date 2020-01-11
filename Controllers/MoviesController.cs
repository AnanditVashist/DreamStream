using DreamStream.Models;
using DreamStream.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace DreamStream.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(c => c.Genre).ToList();
            return View(movies);
        }
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(c => c.Genre).Single(c => c.Id == id);
            return View(movie);
        }

        public ActionResult New()
        {
            var movies = _context.Movies.ToList();
            var genres = _context.Genres.ToList();
            var title = "New Movie";
            var viewModel = new MovieFormViewModel
            {
                Genre = genres,
                Title = title
            };
            return View("MovieForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var movies = _context.Movies.Include(c=>c.Genre).Single(c=>c.Id==id);
            var genres = _context.Genres.ToList();
            var title = "Edit Movie";
            var viewModel = new MovieFormViewModel
            {
                Genre = genres,
                Movie=movies,
                Title=title

            };
            return View("MovieForm",viewModel);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(c => c.Id == movie.Id);
                movieInDb.GenreId = movie.GenreId;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.NumberInStock= movie.NumberInStock;
                movieInDb.Name = movie.Name;
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}