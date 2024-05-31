using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PUConstruir.Data;
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
            List<ServicoModel> servicos = _servicoRepositorio.BuscarTodosServicos();
            return View(servicos);
        }
        public IActionResult Criar()
        {
            return View();
        }   
        public IActionResult Editar(int Id)
        {
            ServicoModel servico = _servicoRepositorio.BuscaPorId(Id);
            return View(servico);
        }
        public IActionResult Deletar()
        {
            return View();
        }
        public IActionResult Visualizar(int Id)
        {
            ServicoModel servico = _servicoRepositorio.BuscaPorId(Id);
            return View(servico);
        }

        [HttpPost]
        public IActionResult Criar(ServicoModel servico)
        {
            _servicoRepositorio.Adicionar(servico);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Editar(ServicoModel servico)
        {
            _servicoRepositorio.Atualizar(servico);
            return RedirectToAction("Index");
        }
    }
}