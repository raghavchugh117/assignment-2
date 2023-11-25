using Microsoft.AspNetCore.Mvc;
using Test2.Models;

namespace Test2.Controllers
{// StudentsController.cs
    public class StudentsController : Controller
    {
        private static List<Student> Students = new List<Student>
    {
        new Student { StudentId = 1, FirstName = "John", LastName = "Doe", GPA = 3, Email = "john@example.com", ProgramId = 1 },
        new Student { StudentId = 2, FirstName = "Jane", LastName = "Smith", GPA = 2, Email = "jane@example.com", ProgramId = 2}
    };

        public IActionResult Index()
        {
            return View(Students);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            // You can add validation, error handling, etc.

            // Assign a new ID to the student
            student.StudentId = Students.Count + 1;

            // Add the new student to the list
            Students.Add(student);

            // Redirect to the index action
            return RedirectToAction(nameof(Index));
        }
    }

}
