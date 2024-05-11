using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PUConstruir.Models;
using PUConstruir.Repositorio;

namespace PUConstruir.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public IActionResult Criar()
        {
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
