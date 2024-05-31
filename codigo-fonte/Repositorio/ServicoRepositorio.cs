using PUConstruir.Data;
using PUConstruir.Models;

namespace PUConstruir.Repositorio
{
    public class ServicoRepositorio : IServicoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ServicoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public ServicoModel BuscaPorId(int Id)
        {
            return _bancoContext.Servicos.FirstOrDefault(x => x.Id == Id);
        } 
        public List<ServicoModel> BuscarTodosServicos()
        {
            return _bancoContext.Servicos.ToList();
        }
        public ServicoModel Adicionar(ServicoModel servico)
        {
            _bancoContext.Servicos.Add(servico);
            _bancoContext.SaveChanges();
            return (servico);
        }

        public ServicoModel Atualizar(ServicoModel servico)
        {
            ServicoModel servicoDB = BuscaPorId(servico.Id);
            if (servicoDB == null) throw new System.Exception("Erro na edição!");

            servicoDB.Nome = servico.Nome;
            servicoDB.Descricao = servico.Descricao;
            servicoDB.ValorPadrao = servico.ValorPadrao;

            _bancoContext.Servicos.Update(servicoDB);
            _bancoContext.SaveChanges();

            return servicoDB;
        }
    }
}
