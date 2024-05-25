using Day25524.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day25524.Models;

namespace Day25524.Controllers
{
    public class BusinessLogiController : Controller
    {
        // GET: BusinessLogi
        public ActionResult Index()
        {
            BusinessLogic b=new BusinessLogic();// create the object for model

            
            Student student = b.GET(3);
            return View(student);
        }
        public String Details()
        {
            return "hii ganga thank u.. :)";
        }
    }
}