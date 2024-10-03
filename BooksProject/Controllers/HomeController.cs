using Microsoft.AspNetCore.Mvc;

namespace BooksProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
