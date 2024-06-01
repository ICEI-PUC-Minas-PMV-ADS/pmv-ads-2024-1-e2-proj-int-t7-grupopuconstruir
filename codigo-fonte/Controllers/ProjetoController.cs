using Microsoft.AspNetCore.Mvc;
using PUConstruir.Filters;
using PUConstruir.Helper;
using PUConstruir.Models;
using PUConstruir.Repositorio;
using PUConstruir.ViewModels;


namespace PUConstruir.Controllers
{
    [UsuarioLogado]
    public class ProjetoController : Controller
    {
        private readonly IProjetoRepositorio _projetoRepositorio;
        private readonly IMaterialRepositorio _materialRepositorio;
        private readonly IServicoRepositorio _servicoRepositorio;
        private readonly ISessao _sessao;

        public ProjetoController(IProjetoRepositorio projetoRepositorio, ISessao sessao, IMaterialRepositorio materialRepositorio, IServicoRepositorio servicoRepositorio)
        {
            _projetoRepositorio = projetoRepositorio;
            _materialRepositorio = materialRepositorio;
            _servicoRepositorio = servicoRepositorio;
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
            UsuarioModel usuarioLogado = _sessao.BuscarSessaoUsuario();
            var viewModel = new ProjetoViewModel
            {
                TodosMateriais = _materialRepositorio.BuscarTodos(usuarioLogado.Id),
                TodosServicos = _servicoRepositorio.BuscarTodos(usuarioLogado.Id)
            };
            return View(viewModel);
        }

        public IActionResult Visualizar(int id)
        {
            ProjetoModel projeto = _projetoRepositorio.BuscarPorId(id);
            return View(projeto);
        }

        public IActionResult Editar(int id)
        {
            UsuarioModel usuarioLogado = _sessao.BuscarSessaoUsuario();
            ProjetoModel projeto = _projetoRepositorio.BuscarPorId(id);
            var viewModel = new ProjetoViewModel
            {
                Projeto = projeto,
                TodosMateriais = _materialRepositorio.BuscarTodos(usuarioLogado.Id),
                TodosServicos = _servicoRepositorio.BuscarTodos(usuarioLogado.Id),
                MateriaisSelecionados = projeto.Materiais.Select(m => m.Id).ToList(),
                ServicosSelecionados = projeto.Servicos.Select(s => s.Id).ToList()
            };
            return View(viewModel);
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
        public IActionResult Criar(ProjetoViewModel viewModel)
        {
            UsuarioModel usuarioLogado = _sessao.BuscarSessaoUsuario();
            viewModel.Projeto.UsuarioId = usuarioLogado.Id;

            // Obtém os materiais selecionados
            var materiaisSelecionados = _materialRepositorio.BuscarTodos(usuarioLogado.Id)
                .Where(m => viewModel.MateriaisSelecionados.Contains(m.Id))
                .ToList();

            // Obtém os serviços selecionados
            var servicosSelecionados = _servicoRepositorio.BuscarTodos(usuarioLogado.Id)
                .Where(s => viewModel.ServicosSelecionados.Contains(s.Id))
                .ToList();

            // Adiciona os materiais ao projeto
            viewModel.Projeto.Materiais = materiaisSelecionados;
            viewModel.Projeto.Servicos = servicosSelecionados;

            _projetoRepositorio.Adicionar(viewModel.Projeto);
            TempData["MensagemSucesso"] = "Projeto cadastrado com sucesso!";
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Editar(ProjetoViewModel viewModel)
        {
            UsuarioModel usuarioLogado = _sessao.BuscarSessaoUsuario();
            viewModel.Projeto.UsuarioId = usuarioLogado.Id;

            // Obtém os materiais selecionados
            var materiaisSelecionados = _materialRepositorio.BuscarTodos(usuarioLogado.Id)
                .Where(m => viewModel.MateriaisSelecionados.Contains(m.Id))
                .ToList();

            // Obtém os serviços selecionados
            var servicosSelecionados = _servicoRepositorio.BuscarTodos(usuarioLogado.Id)
                .Where(s => viewModel.ServicosSelecionados.Contains(s.Id))
                .ToList();

            // Atualiza os dados do projeto
            viewModel.Projeto.Materiais = materiaisSelecionados;
            viewModel.Projeto.Servicos = servicosSelecionados;

            _projetoRepositorio.Editar(viewModel.Projeto);
            TempData["MensagemSucesso"] = "Projeto editado com sucesso!";
            return RedirectToAction("Index");
        }
    }
}
