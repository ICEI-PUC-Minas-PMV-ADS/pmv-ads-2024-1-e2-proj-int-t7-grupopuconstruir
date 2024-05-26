using Microsoft.AspNetCore.Mvc;

namespace PUConstruir.Controllers
{
    public class ProjetoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
