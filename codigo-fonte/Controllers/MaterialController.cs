using Microsoft.AspNetCore.Mvc;
using PUConstruir.Models;
using PUConstruir.Repositorio;

namespace PUConstruir.Controllers
{
    public class MaterialController : Controller
    {
        private readonly IMaterialRepositorio _materialRepositorio;
        public MaterialController(IMaterialRepositorio materialRepositorio)
        {
            _materialRepositorio = materialRepositorio;
        }

        public IActionResult Index()
        {
           List<MaterialModel> materiais = _materialRepositorio.BuscarTodos();

            return View(materiais);
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

        [HttpPost]
        public IActionResult Criar(MaterialModel material)
        {
            _materialRepositorio.Adicionar(material);
            return RedirectToAction("Index");
        }   
    }
}
