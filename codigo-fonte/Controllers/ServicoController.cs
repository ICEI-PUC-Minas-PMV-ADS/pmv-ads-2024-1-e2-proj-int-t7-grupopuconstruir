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

        //OK, AINDA SEM USUARIO
        public IActionResult Index()
        {
            //UsuarioModel usuarioLogado = _sessao.BuscarSessaoUsuario();
            List<ServicoModel> servicos = _servicoRepositorio.BuscarTodosServicos();
            //List<ServicoModel> servicos = _servicoRepositorio.BuscarTodos(usuarioLogado.Id);
            return View(servicos);
        }

        //OK
        public IActionResult Criar()
        {
            return View();
        }

        //OK
        public IActionResult Deletar(int id)
        {
            ServicoModel servico = _servicoRepositorio.BuscarServicosPorId(id);
            return View();
        }

        //OK
        public IActionResult Editar(int id)
        {
            ServicoModel servico = _servicoRepositorio.BuscarServicosPorId(id);
            return View(servico);
        }


        public IActionResult Visualizar(int id)
        {
            ServicoModel servico = _servicoRepositorio.BuscarServicosPorId(id);
            return View(servico);
        }



        [HttpPost]
        public IActionResult Criar(ServicoModel servico)
        {
            _servicoRepositorio.Criar(servico);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Editar(ServicoModel servico)
        {
            _servicoRepositorio.Editar(servico);
            return RedirectToAction("Index");
        }
    }
}