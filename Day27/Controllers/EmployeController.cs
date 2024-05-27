using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day27524.Models;
namespace Day27524.Controllers
{
    public class EmployeController : Controller
    {
        // GET: Employe
        public ActionResult Index()
        {
            Employee e=new Employee();
            var x = e.gen;
            ViewBag.p = x.ToString();

            return View();
        }
    }
}