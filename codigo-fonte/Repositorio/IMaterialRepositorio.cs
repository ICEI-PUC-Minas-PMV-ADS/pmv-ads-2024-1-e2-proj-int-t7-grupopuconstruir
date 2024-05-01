using PUConstruir.Models;

namespace PUConstruir.Repositorio
{
    public interface IMaterialRepositorio
    {
        MaterialModel Adicionar(MaterialModel material);
        
        List<MaterialModel> BuscarTodos();
    }
}
