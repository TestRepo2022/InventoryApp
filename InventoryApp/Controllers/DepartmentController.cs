using InventoryApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApp.Controllers
{
    public class DepartmentController : Controller
    {
        private ApplicationDBContext applicationDB;

        public DepartmentController(ApplicationDBContext dBContext)
        {
            applicationDB = dBContext;
        }
        public IActionResult Index()
        {
            var depts = applicationDB.Departments.ToList();
            return View(depts);
        }

        public IActionResult EmployeeList(int id)
        {
            var emps = applicationDB.employees.Where(e => e.Departments.Id == id).ToList();
            return View(emps);
        } 
        public IActionResult ProjectList(int id)
        {
            var projs = applicationDB.Projects.Where(e => e.Employees.Id == id).ToList();
            return View(projs);
        }
    }
}
