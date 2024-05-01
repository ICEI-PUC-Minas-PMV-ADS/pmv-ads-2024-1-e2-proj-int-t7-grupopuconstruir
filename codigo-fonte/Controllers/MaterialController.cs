using Microsoft.AspNetCore.Mvc;

namespace PUConstruir.Controllers
{
    public class MaterialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
