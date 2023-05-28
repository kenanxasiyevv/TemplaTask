using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace TemplaTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}