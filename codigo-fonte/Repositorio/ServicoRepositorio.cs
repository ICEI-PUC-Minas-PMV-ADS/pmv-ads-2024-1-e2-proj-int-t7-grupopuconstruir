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
        public ServicoModel Adicionar(ServicoModel servico)
        {
            //aqui é onde adiciona-se ao banco de dados via BancoContext
            _bancoContext.Servicos.Add(servico);
            _bancoContext.SaveChanges();
            return (servico);
        }
    }
}
