using PUConstruir.Data;
using PUConstruir.Models;

namespace PUConstruir.Repositorio
{
    public class OrcamentoRepositorio : IOrcamentoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public OrcamentoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public OrcamentoModel Adicionar(OrcamentoModel orcamento)
        {
            throw new NotImplementedException();
        }

        public bool Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public OrcamentoModel BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrcamentoModel> BuscarTodos(int id)
        {
            return _bancoContext.Orcamentos.Where(x => x.UsuarioId == id).ToList();
        }
    }
}
