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

        public IActionResult Editar()
        {
            //var material = _materialRepositorio.BuscarPorId(id);

            //return View(MaterialModel material);
            return View();
        }
        public IActionResult Visualizar()
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

            // Obtém o usuário logado da sessão
            //var usuarioLogado = _sessao.BuscarSessaousuario();


            _materialRepositorio.Adicionar(material);
            return RedirectToAction("Index");
        }   
    }
}
