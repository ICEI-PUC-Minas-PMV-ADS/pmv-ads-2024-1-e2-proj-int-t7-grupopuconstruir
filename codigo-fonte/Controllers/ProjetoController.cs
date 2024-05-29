using Microsoft.AspNetCore.Mvc;
using PUConstruir.Helper;
using PUConstruir.Models;
using PUConstruir.Repositorio;


namespace PUConstruir.Controllers
{
    public class ProjetoController : Controller
    {
        private readonly IProjetoRepositorio _projetoRepositorio;

        public ProjetoController(IProjetoRepositorio projetoRepositorio)
        {
            _projetoRepositorio = projetoRepositorio;
        }

        public IActionResult Index()
        {
            List<ProjetoModel> projetos = _projetoRepositorio.BuscarTodos();

            return View(projetos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Deletar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Visualizar()
        {
            return View();
        }


        [HttpPost]

        public IActionResult Criar(ProjetoModel projeto)
        {
            _projetoRepositorio.Adicionar();
            return RedirectToAction("Index");
        }
    }
}