using Microsoft.AspNetCore.Mvc;
using PUConstruir.Filters;
using PUConstruir.Helper;
using PUConstruir.Models;
using PUConstruir.Repositorio;

namespace PUConstruir.Controllers
{
    [UsuarioLogado]
    public class OrcamentoController : Controller
    {
        private readonly IOrcamentoRepositorio _orcamentoRepositorio;

        private readonly ISessao _sessao;

        public OrcamentoController(IOrcamentoRepositorio orcamentoRepositorio, ISessao sessao)
        {
            _orcamentoRepositorio = orcamentoRepositorio;
            _sessao = sessao;
        }

        public IActionResult Index()
        {
            UsuarioModel usuarioLogado = _sessao.BuscarSessaoUsuario();

            List<OrcamentoModel> orcamentos = _orcamentoRepositorio.BuscarTodos(usuarioLogado.Id);

            return View(orcamentos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Visualizar(int id)
        {
            OrcamentoModel orcamento = _orcamentoRepositorio.BuscarPorId(id);
            return View(orcamento);
        }

        public IActionResult Deletar(int id)
        {
            OrcamentoModel orcamento = _orcamentoRepositorio.BuscarPorId(id);
            return View(orcamento);
        }

        public IActionResult ConfirmarDeletar(int id)
        {
            _orcamentoRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }


        [HttpPost]

        public IActionResult Criar(OrcamentoModel orcamento)
        {
            UsuarioModel usuarioLogado = _sessao.BuscarSessaoUsuario();
            orcamento.UsuarioId = usuarioLogado.Id;
            _orcamentoRepositorio.Adicionar(orcamento);
            return RedirectToAction("Index");
        }

    }
}
