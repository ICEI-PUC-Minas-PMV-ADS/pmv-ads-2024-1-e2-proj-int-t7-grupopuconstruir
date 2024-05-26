using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PUConstruir.Helper;
using PUConstruir.Models;
using PUConstruir.Repositorio;

namespace PUConstruir.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly ISessao _sessao;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio, ISessao sessao)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _sessao = sessao;
        }

        public IActionResult Criar()
        {
            if (_sessao.BuscarSessaoUsuario() != null) return RedirectToAction("Index", "Index");
            return View();
        }

        public IActionResult RecuperarSenha()
        {
            return View();
        }

        public IActionResult Perfil()
        {
            List<UsuarioModel> usuarios = _usuarioRepositorio.BuscarTodos();
            return View(usuarios);
        }

        [HttpPost]
        public IActionResult Criar(UsuarioModel usuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    usuario = _usuarioRepositorio.Adicionar(usuario);
                    TempData["MensagemSuccesso"] = "Usuário cadastrado com sucesso!";
                    _sessao.CriarSessaoUsuario(usuario);
                    return RedirectToAction("Index", "Index");
                }
                return View(usuario);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu usuário, tente novamente.";
                return RedirectToAction("Criar");
            }
        }
    }
}
