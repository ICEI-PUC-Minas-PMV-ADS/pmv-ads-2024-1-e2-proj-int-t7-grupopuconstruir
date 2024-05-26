using Microsoft.AspNetCore.Mvc;

namespace PUConstruir.Controllers
{
    public class ServicoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult Deletar()
        {
            return View();
        }
    }
}