using Microsoft.AspNetCore.Mvc;
using PUConstruir.Filters;

namespace PUConstruir.Controllers
{
    public class IndexController : Controller
    {
        [UsuarioLogado]
        public IActionResult Index()
        {
            return View();
        }

    }
}
