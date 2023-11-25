using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Test2.Models;

namespace Test2.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View(Repository.AllStudents);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)

        {
            Repository.Create(student);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}