using PUConstruir.Models;

namespace PUConstruir.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel ValidarLogin(string email);
        UsuarioModel BuscarPorId(int id);
        UsuarioModel Adicionar(UsuarioModel usuario);
    }
}
