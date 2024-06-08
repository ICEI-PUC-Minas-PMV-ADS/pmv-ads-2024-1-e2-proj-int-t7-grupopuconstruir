using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PUConstruir.Data;
using PUConstruir.Filters;
using PUConstruir.Helper;
using PUConstruir.Models;
using PUConstruir.Repositorio;

namespace PUConstruir.Controllers
{
    [UsuarioLogado]
    public class ServicoController : Controller
    {
        private readonly IServicoRepositorio _servicoRepositorio;

        private readonly ISessao _sessao;

        public ServicoController(IServicoRepositorio servicoRepositorio, ISessao sessao)
        {
            _servicoRepositorio = servicoRepositorio;
            _sessao = sessao;
        }

        //OK
        public IActionResult Index()
        {
            UsuarioModel usuarioLogado = _sessao.BuscarSessaoUsuario();
            List<ServicoModel> servicos = _servicoRepositorio.BuscarTodos(usuarioLogado.Id);
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
            ServicoModel servico = _servicoRepositorio.BuscarPorId(id);
            return View(servico);
        }
        public IActionResult ConfirmarDeletar(int id)
        {
            _servicoRepositorio.Deletar(id);
            return RedirectToAction("Index");
        }

        //OK
        public IActionResult Editar(int id)
        {
            ServicoModel servico = _servicoRepositorio.BuscarPorId(id);
            return View(servico);
        }

        //OK
        public IActionResult Visualizar(int id)
        {
            ServicoModel servico = _servicoRepositorio.BuscarPorId(id);
            return View(servico);
        }



        [HttpPost]
        public IActionResult Criar(ServicoModel servico)
        {
            UsuarioModel usuarioLogado = _sessao.BuscarSessaoUsuario();
            servico.UsuarioId = usuarioLogado.Id;
            _servicoRepositorio.Criar(servico);
            TempData["MensagemSucesso"] = "Serviço cadastrado com sucesso!";
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Editar(ServicoModel servico)
        {
            UsuarioModel usuarioLogado = _sessao.BuscarSessaoUsuario();
            servico.UsuarioId = usuarioLogado.Id;
            _servicoRepositorio.Editar(servico);
            TempData["MensagemSucesso"] = "Serviço editado com sucesso!";
            return RedirectToAction("Index");
        }
    }
}