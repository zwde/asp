using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
      
        public ActionResult GetView()
        {
            Employee emp = new Employee();
            emp.FirstName = "Lebron";
            emp.LastName = "James";
            emp.Salary = 20000;

            ViewData["Employee"] = emp;

            return View("MyView");
        }
        public string GetString()
        {
            return "Hello World";
        }
    }
}