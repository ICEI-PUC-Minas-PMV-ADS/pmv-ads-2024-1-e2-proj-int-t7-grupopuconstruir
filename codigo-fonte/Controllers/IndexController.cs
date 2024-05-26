using Microsoft.AspNetCore.Mvc;

namespace PUConstruir.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
