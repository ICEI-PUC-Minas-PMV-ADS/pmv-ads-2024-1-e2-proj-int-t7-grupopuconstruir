using PUConstruir.Models;

namespace PUConstruir.Repositorio
{
    public interface IServicoRepositorio
    {
        List<ServicoModel> BuscarTodosServicos();
        ServicoModel BuscaPorId(int Id);
        ServicoModel Adicionar(ServicoModel servico);
        ServicoModel Atualizar(ServicoModel servico);

    }
}
