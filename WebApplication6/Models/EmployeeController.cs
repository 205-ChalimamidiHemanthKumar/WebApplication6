using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            IList<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { ID = 205, FirstName = "Hemanth", LastName = "Kumar" });
            employees.Add(new Employee() { ID = 206, FirstName = "Surya", LastName = "c" });
            employees.Add(new Employee() { ID = 207, FirstName = "Rohit", LastName = "c" });

            ViewData["employees"] = employees;

            ViewBag.TotalEmployees = employees.Count();
            ViewBag.CompanyName = "IBM";
            return View();
        }
    }
}
