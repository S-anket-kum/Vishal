using Microsoft.AspNetCore.Mvc;
using Vishal.Models;

namespace Vishal.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Student()
        {
            Student student = new Student
            {
                Id = 1,
                Name = "Vishal",
                Gender = "Female"
            };

            return View(student);
        }
    }
}
