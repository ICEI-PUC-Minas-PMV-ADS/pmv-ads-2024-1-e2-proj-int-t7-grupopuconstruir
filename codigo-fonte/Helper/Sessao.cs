using Newtonsoft.Json;
using PUConstruir.Models;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using System.Drawing;

namespace PUConstruir.Helper
{
    public class Sessao : ISessao
    {
        private readonly IHttpContextAccessor _httpContext;

        public Sessao(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }

        public void CriarSessaoUsuario(UsuarioModel usuario)
        {
            string valor = JsonConvert.SerializeObject(usuario);
            _httpContext.HttpContext.Session.SetString("sessaoUsuarioLogado", valor);
        }

        public UsuarioModel BuscarSessaoUsuario()
        {
            string sessaoUsuario = _httpContext.HttpContext.Session.GetString("sessaoUsuarioLogado");

            if (string.IsNullOrEmpty(sessaoUsuario)) return null;
            return JsonConvert.DeserializeObject<UsuarioModel>(sessaoUsuario);
        }

        public void RemoverSessaoUsuario()
        {
            _httpContext.HttpContext.Session.Remove("sessaoUsuarioLogado");
        }
    }
}
