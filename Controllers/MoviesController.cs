using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
  public class MoviesController : Controller
  {
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