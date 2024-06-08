using PUConstruir.Models;

namespace PUConstruir.Repositorio
{
    public interface IMaterialRepositorio
    {
        MaterialModel Adicionar(MaterialModel material);
        
        List<MaterialModel> BuscarTodos(int id);

        MaterialModel BuscarPorId(int id);

        MaterialModel Atualizar(MaterialModel material);

        bool Apagar(int id);
        
    }
}
