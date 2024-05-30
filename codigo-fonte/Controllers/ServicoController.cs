using Microsoft.AspNetCore.Mvc;
using PUConstruir.Filters;
using PUConstruir.Models;
using PUConstruir.Repositorio;

namespace PUConstruir.Controllers
{
    [UsuarioLogado]
    public class ServicoController : Controller
    {
        private readonly IServicoRepositorio _servicoRepositorio;
        public ServicoController(IServicoRepositorio servicoRepositorio)
        {
            _servicoRepositorio = servicoRepositorio;
        }
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
        public IActionResult Visualizar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(ServicoModel servico)
        {
            _servicoRepositorio.Adicionar(servico);
            return RedirectToAction("Index");
        }
    }
}