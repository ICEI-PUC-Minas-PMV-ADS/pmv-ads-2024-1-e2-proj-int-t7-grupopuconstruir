using System;
using PUConstruir.Repositorio;
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

        //OK
        public List<ServicoModel> BuscarTodosServicos()
        //Também funciona
        //public List<ServicoModel> BuscarTodosServicos(int id)
        {
            //Funcionará como:
            //return _bancoContext.Servicos.Where(s => s.UsuarioId == id).ToList();
            
            return _bancoContext.Servicos.ToList();
        }

        //OK
        public ServicoModel BuscarServicosPorId(int id)
        {
            return _bancoContext.Servicos.FirstOrDefault(s => s.Id == id);
        } 
               

        //OK
        public ServicoModel Criar(ServicoModel servico)
        {
            _bancoContext.Servicos.Add(servico);
            _bancoContext.SaveChanges();
            return (servico);
        }

        //OK
        public ServicoModel Editar(ServicoModel servico)
        {
            ServicoModel servicoDB = BuscarServicosPorId(servico.Id);
            if (servicoDB == null) throw new System.Exception("Erro na edição!");

            servicoDB.Nome = servico.Nome;
            servicoDB.Descricao = servico.Descricao;
            servicoDB.ValorPadrao = servico.ValorPadrao;

            _bancoContext.Servicos.Update(servicoDB);
            _bancoContext.SaveChanges();

            return servicoDB;
        }

        // EM IMPLEMENTACAO
        //public bool DetelarServico(int id)
        //{
        //    ServicoModel servicoDB = BuscarServicosPorId(id) ?? throw new System.Exception($"Foi encontrado um erro ao excluir o Servico. ID {id} não foi encontrado no banco de dados");

        //    _bancoContext.Servicos.Remove(servicoDB);
        //    _bancoContext.SaveChanges();

        //    return true;
        //}
    }
}
