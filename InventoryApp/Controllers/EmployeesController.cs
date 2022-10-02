using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryApp.Models;
namespace InventoryApp.Controllers
{
    public class EmployeesController : Controller
    {
        private ApplicationDBContext applicationDB;
        public EmployeesController(ApplicationDBContext dBContext)
        {
            applicationDB = dBContext;
        }
        public IActionResult Index()
        {
            var employees = applicationDB.employees.ToList();
            return View(employees);
        }

        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Employees employees)
        {
            applicationDB.employees.Add(employees);
            applicationDB.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            var emp = applicationDB.employees.SingleOrDefault(e => e.Id == Id);
            if (emp != null)
            {
                applicationDB.employees.Remove(emp);
                applicationDB.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }


        public IActionResult Edit(int Id)
        {
            var emp = applicationDB.employees.SingleOrDefault(e => e.Id == Id);
            if (emp != null)
            {
                return View(emp);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Edit(Employees em)
        {
            var emp = applicationDB.employees.SingleOrDefault(e => e.Id == em.Id);
            if (emp != null)
            {
                emp.Name = em.Name;
                emp.Email = em.Email;
                emp.Address = em.Address;
                applicationDB.employees.Update(emp);
                applicationDB.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
