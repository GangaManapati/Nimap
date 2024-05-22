using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day22.Models;
using Day22.ViewModel;

namespace Day22.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var m = new Movie(){ Name = "KGF"};
            var Custo = new List<Customer>
            {
                new Customer{Name="Customer1"},
                new Customer{Name="Customer2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                M = m,
                Cus = Custo
            };







            //var xr = new ViewResult();
            //xr.ViewData.Model

            return View(viewModel);
        }
        //public ActionResult Edit(int Id)
        //{
        //    return Content("my is=" + Id);
        //}
        //public ActionResult index(int? PageNo, String Nam)
        //{
        //    if (!PageNo.HasValue)
        //    {
        //        PageNo = 1;
        //    }
        //    if (String.IsNullOrEmpty(Nam))
        //    {
        //        Nam = "manapati";
        //    }
        //    return Content(String.Format("Page number :{0} &Name is={1}", PageNo, Nam));
        //}

        // //[Route("movies/released/{year:range(2000,2025)}/{month:int:range(1,12)}")]
        ////[Route("movies/released/{year:int}/{month:int:range(1,12)}")]
        //[Route("movies/released/{year:int:regex(\\d{4})}/{month:int:range(1,12)}")]

        ////public ActionResult ByReleaseDate(int year, int month)
        ////{
        ////    return Content(year + "/" + month);

        ////}



    }
}