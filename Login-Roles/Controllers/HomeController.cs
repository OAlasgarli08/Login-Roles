using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Login_Roles.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
