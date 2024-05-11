using Microsoft.AspNetCore.Mvc;
using PUConstruir.Models;

namespace PUConstruir.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Logar(LoginModel loginModel)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    return RedirectToAction("Index", "Index");
                }
                return View("Index");
            }
            catch (Exception erro) {
                TempData["MensagemErro"] = $"Ops, não conseguimos realizar seu login, tente novamente: {erro.Message}";
                return RedirectToAction("Criar");
            }
            return View();
        }
    }
}
