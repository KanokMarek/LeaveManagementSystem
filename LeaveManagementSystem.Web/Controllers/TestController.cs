using Microsoft.AspNetCore.Mvc;
using LeaveManagementSystem.Web.Models;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModul
            {
                Name = "Student of MVC mastery",
                DateOfBirth = new DateTime(1954, 01, 27)
            };
            return View(data);
        }
    }
}
