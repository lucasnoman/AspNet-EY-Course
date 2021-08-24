using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
  public class CustomersController : Controller
  {
    // GET: Customers
    public ActionResult Index()
    {
      return View(putCustomersOnViewList());
    }

    public ActionResult Details(int id)
    {
      var customer = setCustomers().SingleOrDefault(c => c.Id == id);

      if (customer == null)
      {
        return HttpNotFound();
      }

      return View();
    }

    private List<Customer> setCustomers()
    {
      return new List<Customer>()
      {
        new Customer {Id = 1, Name = "Joaozinho"},
        new Customer {Id = 2, Name = "Mariazinha"}
      };
    }

    private RandomMovieViewModel putCustomersOnViewList()
    {
      var customerList = new RandomMovieViewModel()
      {
        Customers = setCustomers()
      };

      return customerList;
    }
  }
}