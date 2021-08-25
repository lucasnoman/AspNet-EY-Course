using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
  public class MoviesController : Controller
  {
    private ApplicationDbContext _context;

    public MoviesController()
    {
      _context = new ApplicationDbContext();
    }

    protected override void Dispose(bool disposing)
    {
      _context.Dispose();
    }

    public ViewResult Index()
    {
      var movies = _context.Movies.Include(m => m.Genre).ToList();

      return View(movies);
    }

    public ActionResult Details(int id)
    {
      var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

      if (movie == null)
        return HttpNotFound();

      return View(movie);
    }

    // GET: Movies/Random
    public ActionResult Random()
    {
      return View(putMoviesOnViewList());
    }

    private List<Movie> setMovies()
    {
      return new List<Movie>()
      {
        new Movie {Name = "Shrek"},
        new Movie {Name = "Planeta dos Macacos"}
      };
    }

    private RandomMovieViewModel putMoviesOnViewList()
    {
      return new RandomMovieViewModel()
      {
        Movie = setMovies()
      };
    }
  }
}