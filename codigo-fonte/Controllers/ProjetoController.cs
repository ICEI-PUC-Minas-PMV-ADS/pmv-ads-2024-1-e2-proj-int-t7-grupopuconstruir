using Microsoft.AspNetCore.Mvc;
using PUConstruir.Filters;
using PUConstruir.Helper;
using PUConstruir.Models;
using PUConstruir.Repositorio;


namespace PUConstruir.Controllers
{
    [UsuarioLogado]
    public class ProjetoController : Controller
    {
        private readonly IProjetoRepositorio _projetoRepositorio;

        private readonly ISessao _sessao;

        public ProjetoController(IProjetoRepositorio projetoRepositorio, ISessao sessao)
        {
            _projetoRepositorio = projetoRepositorio;
            _sessao = sessao;
        }

        public IActionResult Index()
        {
            UsuarioModel usuarioLogado = _sessao.BuscarSessaoUsuario();
            List<ProjetoModel> projetos = _projetoRepositorio.BuscarTodos(usuarioLogado.Id);
            return View(projetos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Visualizar(int id)
        {
            ProjetoModel projeto = _projetoRepositorio.BuscarPorId(id);
            return View(projeto);
        }

        public IActionResult Editar(int id)
        {
            ProjetoModel projeto = _projetoRepositorio.BuscarPorId(id);
            return View(projeto);
        }

        public IActionResult Deletar(int id)
        {
            ProjetoModel projeto = _projetoRepositorio.BuscarPorId(id);
            return View(projeto);
        }

        public IActionResult ConfirmarDeletar(int id)
        {
            _projetoRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]

        public IActionResult Criar(ProjetoModel projeto)
        {
            UsuarioModel usuarioLogado = _sessao.BuscarSessaoUsuario();
            projeto.UsuarioId = usuarioLogado.Id;
            _projetoRepositorio.Adicionar(projeto);
            TempData["MensagemSucesso"] = "Projeto cadastrado com sucesso!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(ProjetoModel projeto)
        {
            UsuarioModel usuarioLogado = _sessao.BuscarSessaoUsuario();
            projeto.UsuarioId = usuarioLogado.Id;
            _projetoRepositorio.Editar(projeto);
            TempData["MensagemSucesso"] = "Projeto editado com sucesso!";
            return RedirectToAction("Index");
        }
    }
}