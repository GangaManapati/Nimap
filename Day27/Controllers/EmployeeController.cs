using Day27524.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day27524.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {

            Employee emp = new Employee {
                EmpId = 212,
                EmpName = "ganga",
                EmpAddress = "basanapalli,Andhrapradesh",
                EmpPhno = "76637234344",
                Password = "ygdgytgyb",
                IsPermant = true

            };
            return View(emp);
        }
    }
}