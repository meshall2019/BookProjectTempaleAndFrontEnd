using Microsoft.AspNetCore.Mvc;

namespace BooksProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminPageController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
