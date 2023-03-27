using Microsoft.AspNetCore.Mvc;
using SanaTask1.Models;

namespace SanaTask1.Controllers
{
    public class Task1Controller : Controller
    {
        public IActionResult Index(User user)
        {
            return View(user);
        }
    }
}
