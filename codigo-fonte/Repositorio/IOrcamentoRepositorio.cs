using PUConstruir.Data;
using PUConstruir.Models;

namespace PUConstruir.Repositorio
{
    public interface IOrcamentoRepositorio
    {
        OrcamentoModel Adicionar(OrcamentoModel orcamento);

        List<OrcamentoModel> BuscarTodos();

        OrcamentoModel BuscarPorId(int id);

        OrcamentoModel Atualizar(OrcamentoModel orcamento);
    }
}
