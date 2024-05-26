using Microsoft.AspNetCore.Mvc;
using PUConstruir.Helper;
using PUConstruir.Models;
using PUConstruir.Repositorio;

namespace PUConstruir.Controllers
{
    public class MaterialController : Controller
    {
        private readonly IMaterialRepositorio _materialRepositorio;
        
        private readonly ISessao _sessao;

        public MaterialController(IMaterialRepositorio materialRepositorio, ISessao sessao)
        {
            _materialRepositorio = materialRepositorio;
            _sessao = sessao;
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

        public IActionResult Editar(int id)
        {
            MaterialModel material = _materialRepositorio.BuscarPorId(id);
         
            return View(material);
        }

        public IActionResult Visualizar(int id)
        {
            MaterialModel material = _materialRepositorio.BuscarPorId(id);

            return View(material);
        }

        public IActionResult Deletar(int id)
        {
            MaterialModel material = _materialRepositorio.BuscarPorId(id);

            return View(material);
        }

        public IActionResult ConfirmarDeletar(int id)
        {

            _materialRepositorio.Apagar(id);
             
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Criar(MaterialModel material)
        {
            _materialRepositorio.Adicionar(material);
            
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alterar(MaterialModel material)
        {
            _materialRepositorio.Atualizar(material);
            
            return RedirectToAction("Index");
        }
    }
}
