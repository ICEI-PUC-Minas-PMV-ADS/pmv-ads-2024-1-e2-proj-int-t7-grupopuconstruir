using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PUConstruir.Filters;
using PUConstruir.Helper;
using PUConstruir.Models;
using PUConstruir.Repositorio;
using PUConstruir.ViewModels;
using System.Linq.Expressions;

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
            return View();
        }

        [UsuarioLogado]
        public IActionResult Perfil(int id) 
        {
            UsuarioModel usuarioLogado = _sessao.BuscarSessaoUsuario();
            UsuarioModel usuario = _usuarioRepositorio.BuscarPorId(usuarioLogado.Id);
            return View(usuario);
        }

        [UsuarioLogado]
        public IActionResult AlterarSenha()
        {
            return View();
        }

        public IActionResult Deletar(int id)
        {
            UsuarioModel usuarioLogado = _sessao.BuscarSessaoUsuario();
            UsuarioModel usuario = _usuarioRepositorio.BuscarPorId(usuarioLogado.Id);
            return View(usuario);
        }

        public IActionResult ConfirmarDeletar(int id)
        {
            try
            {
                _usuarioRepositorio.Apagar(id);

                TempData["MensagemSucesso"] = "Conta excluída com sucesso!";
                _sessao.RemoverSessaoUsuario();
                return RedirectToAction("Index", "Login");
            }
            catch (Exception ex)
            {
                TempData["MensagemErro"] = $"Erro ao excluir a conta: {ex.Message}";
                return RedirectToAction("Perfil");
            }
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
                return RedirectToAction("Login", "Index");
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [UsuarioLogado]
        public IActionResult AlterarSenha(AlterarSenhaViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    UsuarioModel usuario = _sessao.BuscarSessaoUsuario();
                    UsuarioModel usuarioDB = _usuarioRepositorio.BuscarPorId(usuario.Id);

                    if (usuarioDB == null)
                        throw new Exception("Usuário não encontrado!");

                    usuarioDB.Senha = model.NovaSenha.gerarHash();
                    _usuarioRepositorio.Editar(usuarioDB);

                    TempData["MensagemSucesso"] = "Senha alterada com sucesso!";
                    return RedirectToAction("Perfil");
                }
                catch (Exception ex)
                {
                    TempData["MensagemErro"] = $"Erro ao alterar a senha: {ex.Message}";
                }
            }
            return View(model);
        }
    }
}
