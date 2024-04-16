using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Writer.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
