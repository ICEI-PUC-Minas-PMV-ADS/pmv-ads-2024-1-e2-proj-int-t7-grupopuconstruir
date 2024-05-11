using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PUConstruir.Controllers
{
    public class ServicoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
