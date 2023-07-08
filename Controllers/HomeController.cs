using Microsoft.AspNetCore.Mvc;

namespace KutuphaneProjesı.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Book()
        {
            return View();
        }

        public IActionResult Categoory()
        {
            return View();
        }

        public IActionResult Student()
        {
            return View();
        }
    }
}
