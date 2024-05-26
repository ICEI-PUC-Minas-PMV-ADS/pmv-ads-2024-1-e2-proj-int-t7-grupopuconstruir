using PUConstruir.Models;

namespace PUConstruir.Helper
{
    public interface ISessao
    {
        void CriarSessaoUsuario(UsuarioModel usuario);

        void RemoverSessaoUsuario();

        UsuarioModel BuscarSessaoUsuario();
    }
}
