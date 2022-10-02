using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryApp.Models;

namespace InventoryApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            /*
            string msg = "This is very important message";
            ViewBag.message = msg;

            var students = new List<string>() { "Rakesh", "Ajay", "Amit", "Suraj" };
            ViewBag.students = students;
            */

            //string msg = "This is very important message";
            //ViewData["message"] = msg;

            //var students = new List<string>() { "Rakesh", "Ajay", "Amit", "Suraj" };
            //ViewData["students"] = students;

            List<Customer> customers = new List<Customer>()
            {
                new Customer(){Name="Ajay kumar",Address="New delhi"},
                new Customer(){Name="Rakesh kumar",Address="New delhi"},
                new Customer(){Name="Amit kumar",Address="Old delhi"},
                new Customer(){Name="Pawan kumar",Address="New delhi"},
                new Customer(){Name="Dev kumar",Address="South delhi"},

            };


            return View(customers);
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Blogs()
        {
            return View();
        }
        
        public IActionResult Careers()
        {
            return View();
        }


    }
}
