﻿using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModels
{
  public class RandomMovieViewModel
  {
    public List<Movie> Movie { get; set; }
    public List<Customer> Customers { get; set; }
  }
}