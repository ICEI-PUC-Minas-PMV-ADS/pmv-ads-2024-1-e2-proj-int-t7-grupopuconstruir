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
            OrcamentoModel orcamentoDB = BuscarPorId(id) ?? throw new System.Exception($"Erro ao tentar deletar o Orçamento. ID {id} não encontrado no banco de dados");

            _bancoContext.Orcamentos.Remove(orcamentoDB);
            _bancoContext.SaveChanges();

            return true;
        }

        public OrcamentoModel BuscarPorId(int id)
        {
            return _bancoContext.Orcamentos.FirstOrDefault(x => x.Id == id);
        }

        public List<OrcamentoModel> BuscarTodos(int id)
        {
            return _bancoContext.Orcamentos.Where(x => x.UsuarioId == id).ToList();
        }
    }
}
