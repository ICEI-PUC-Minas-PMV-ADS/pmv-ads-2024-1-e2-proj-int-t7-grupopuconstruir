using Microsoft.AspNetCore.Mvc;
using PUConstruir.Helper;
using PUConstruir.Models;
using PUConstruir.Repositorio;

namespace PUConstruir.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly ISessao _sessao;

        public LoginController(IUsuarioRepositorio usuarioRepositorio, ISessao sessao)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _sessao = sessao;
        }

        public IActionResult Index()
        {
            //Se o usuário já estiver logado, direcionar para home
            if (_sessao.BuscarSessaousuario() != null) return RedirectToAction("Index", "Index");
            return View();
        }

        public IActionResult Deslogar()
        {
            _sessao.RemoverSessaoUsuario();
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public IActionResult Index(LoginModel loginModel)
        {
            try
            {
                UsuarioModel usuario = _usuarioRepositorio.ValidarLogin(loginModel.Email);

                if (usuario != null)
                {
                    if (usuario.SenhaValida(loginModel.Senha))
                    {
                        _sessao.CriarSessaoUsuario(usuario);
                        return RedirectToAction("Index", "Index");
                    }
                    TempData["MensagemErro"] = $"Senha inválida, tente novamente";

                }
                TempData["MensagemErro"] = $"Usuário e/ou senha inválido(s), tente novamente";
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos realizar seu login, tente novamente.";
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
