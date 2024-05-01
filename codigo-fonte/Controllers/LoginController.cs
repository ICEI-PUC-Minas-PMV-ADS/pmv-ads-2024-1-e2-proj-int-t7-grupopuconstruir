using Microsoft.AspNetCore.Mvc;

namespace PUConstruir.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
