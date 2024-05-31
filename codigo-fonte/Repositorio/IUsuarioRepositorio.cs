using PUConstruir.Models;

namespace PUConstruir.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel ValidarLogin(string email);
        List<UsuarioModel> BuscarTodos();
        UsuarioModel BuscarPorId(int id);
        UsuarioModel Adicionar(UsuarioModel usuario);
    }
}
