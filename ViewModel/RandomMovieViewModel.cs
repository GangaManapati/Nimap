using Day22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day22.ViewModel
{
    public class RandomMovieViewModel
    {
        public Movie M { get; set; }    
        public List<Customer> Cus { get; set; }
    }
}