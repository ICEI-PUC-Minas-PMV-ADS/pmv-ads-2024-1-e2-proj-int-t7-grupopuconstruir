using Microsoft.AspNetCore.Mvc;
using PUConstruir.Filters;
using PUConstruir.Helper;
using PUConstruir.Models;
using PUConstruir.Repositorio;

namespace PUConstruir.Controllers
{
    [UsuarioLogado]
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
            UsuarioModel usuarioLogado =  _sessao.BuscarSessaoUsuario();

            List<MaterialModel> materiais = _materialRepositorio.BuscarTodos(usuarioLogado.Id);
            
            return View(materiais);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Visualizar(int id)
        {
            MaterialModel material = _materialRepositorio.BuscarPorId(id);

            return View(material);
        }

        public IActionResult Editar(int id) 
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
            UsuarioModel usuarioLogado = _sessao.BuscarSessaoUsuario();
            material.UsuarioId = usuarioLogado.Id;
            _materialRepositorio.Adicionar(material);
            TempData["MensagemSucesso"] = "Material cadastrado com sucesso!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alterar(MaterialModel material)
        {
            UsuarioModel usuarioLogado = _sessao.BuscarSessaoUsuario();
            material.UsuarioId = usuarioLogado.Id;
            _materialRepositorio.Atualizar(material);
            TempData["MensagemSucesso"] = "Material editado com sucesso!";
            return RedirectToAction("Index");
        }
    }
}
