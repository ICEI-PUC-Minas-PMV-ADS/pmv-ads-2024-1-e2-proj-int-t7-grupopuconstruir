using Microsoft.AspNetCore.Mvc;
using PUConstruir.Filters;
using PUConstruir.Helper;
using PUConstruir.Models;
using PUConstruir.Repositorio;
using PUConstruir.ViewModels;

namespace PUConstruir.Controllers
{
    [UsuarioLogado]
    public class OrcamentoController : Controller
    {
        private readonly IOrcamentoRepositorio _orcamentoRepositorio;
        private readonly IProjetoRepositorio _projetoRepositorio;
        private readonly ISessao _sessao;

        public OrcamentoController(IOrcamentoRepositorio orcamentoRepositorio, ISessao sessao, IProjetoRepositorio projetoRepositorio)
        {
            _orcamentoRepositorio = orcamentoRepositorio;
            _projetoRepositorio = projetoRepositorio;
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
            UsuarioModel usuarioLogado = _sessao.BuscarSessaoUsuario();
            var viewModel = new OrcamentoViewModel
            {
                TodosProjetos = _projetoRepositorio.BuscarTodos(usuarioLogado.Id)
            };
            return View(viewModel);
        }

        public IActionResult Visualizar(int id)
        {
            OrcamentoModel orcamento = _orcamentoRepositorio.BuscarPorId(id);
            return View(orcamento);
        }

        public IActionResult Editar(int id)
        {
            UsuarioModel usuarioLogado = _sessao.BuscarSessaoUsuario();
            OrcamentoModel orcamento = _orcamentoRepositorio.BuscarPorId(id);
            var viewModel = new OrcamentoViewModel
            {
                Orcamento = orcamento,
                TodosProjetos = _projetoRepositorio.BuscarTodos(usuarioLogado.Id),
                ProjetosSelecionados = orcamento.Projetos.Select(m => m.Id).ToList(),
            };
            return View(viewModel);

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
        public IActionResult Criar(OrcamentoViewModel viewModel)
        {
            UsuarioModel usuarioLogado = _sessao.BuscarSessaoUsuario();
            viewModel.Orcamento.UsuarioId = usuarioLogado.Id;

            var projetosSelecionados = _projetoRepositorio.BuscarTodos(usuarioLogado.Id)
                .Where(p => viewModel.ProjetosSelecionados.Contains(p.Id))
                .ToList();

            viewModel.Orcamento.Projetos = projetosSelecionados;

            _orcamentoRepositorio.Adicionar(viewModel.Orcamento);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Editar(OrcamentoViewModel viewModel)
        {
            UsuarioModel usuarioLogado = _sessao.BuscarSessaoUsuario();
            viewModel.Orcamento.UsuarioId = usuarioLogado.Id;

            // Obtém os projetos selecionados
            var projetosSelecionados = _projetoRepositorio.BuscarTodos(usuarioLogado.Id)
                .Where(m => viewModel.ProjetosSelecionados.Contains(m.Id))
                .ToList();

            // Atualiza os dados do projeto
            viewModel.Orcamento.Projetos = projetosSelecionados;

            _orcamentoRepositorio.Editar(viewModel.Orcamento);
            TempData["MensagemSucesso"] = "Projeto editado com sucesso!";
            return RedirectToAction("Index");
        }
    }
}