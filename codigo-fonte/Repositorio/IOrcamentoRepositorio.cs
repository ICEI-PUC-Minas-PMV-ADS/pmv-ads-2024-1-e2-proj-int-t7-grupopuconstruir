using PUConstruir.Data;
using PUConstruir.Models;

namespace PUConstruir.Repositorio
{
    public interface IOrcamentoRepositorio
    {
        OrcamentoModel Adicionar(OrcamentoModel orcamento);

        List<OrcamentoModel> BuscarTodos(int id);

        OrcamentoModel BuscarPorId(int id);

        bool Apagar(int id);
    }
}
