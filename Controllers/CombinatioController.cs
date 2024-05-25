using Day25524.CominationClass;
using Day25524.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day25524.Controllers
{
    public class CombinatioController : Controller
    {
        // GET: Combinatio
        public ActionResult Index()
        {
            Student s = new Student
            {
                Id = 112,
                Name = "gnaga",
                gender = "female",
                branch = "CSE",
                session = 1
            };
            Markas m = new Markas
            {
                id = 112,
                english = 98,
                teludu = 45,
                maths = 100
            };
            Combinatio c = new Combinatio
            {
                Id = 112,
                stu = s,
                Mar = m
            };
            return View(c);
        }
    }
}