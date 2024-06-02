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
        private readonly IEmail _email;

        public LoginController(IUsuarioRepositorio usuarioRepositorio, ISessao sessao, IEmail email)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _sessao = sessao;
            _email = email;
        }

        public IActionResult Index()
        {
            //Se o usuário já estiver logado, direcionar para home
            if (_sessao.BuscarSessaoUsuario() != null) return RedirectToAction("Index", "Index");
            return View();
        }
        public IActionResult RecuperarSenha()
        {
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

        [HttpPost]
        public IActionResult RecuperarSenha(RecuperarSenhaModel recuperarSenhaModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    UsuarioModel usuario = _usuarioRepositorio.ValidarLogin(recuperarSenhaModel.Email);

                    if (usuario != null)
                    {
                        string novaSenha = usuario.gerarNovaSenha();
                        string mensagem = $"Senha alterada com sucesso!<br>Sua nova senha é: {novaSenha}";

                        bool emailEnviado = _email.Enviar(usuario.Email, "PUConstruir - Nova Senha", mensagem);

                        if (emailEnviado)
                        {
                            _usuarioRepositorio.Editar(usuario);
                            TempData["MensagemSucesso"] = $"Enviamos uma nova senha para seu e-mail.";
                        }
                        else
                        {
                            TempData["MensagemErro"] = $"Não conseguimos enviar o e-mail, tente novamente.";
                        }

                        return RedirectToAction("Index", "Login");
                    }

                    TempData["MensagemErro"] = $"Não conseguimos redefinir sua senha. Por favor, verifique os dados informados.";
                }

                return View("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos redefinir sua senha, tente novamante, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
