using PUConstruir.Models;

namespace PUConstruir.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel ValidarLogin(string email);
        UsuarioModel Editar(UsuarioModel usuario);
        List<UsuarioModel> BuscarTodos();
        UsuarioModel BuscarPorId(int id);
        UsuarioModel Adicionar(UsuarioModel usuario);
    }
}
