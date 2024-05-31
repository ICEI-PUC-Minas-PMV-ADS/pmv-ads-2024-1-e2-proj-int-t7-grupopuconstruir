using System;
using System.Collections.Generic;
using System.Linq;
using PUConstruir.Repositorio;
using PUConstruir.Data;
using PUConstruir.Helper;
using PUConstruir.Models;

namespace PUConstruir.Repositorio
{
    public class ProjetoRepositorio : IProjetoRepositorio
    {

        private readonly BancoContext _bancoContext;
        public ProjetoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public ProjetoModel Adicionar(ProjetoModel projeto)
        {
            //aqui é onde adiciona-se ao banco de dados via BancoContext
            _bancoContext.Projetos.Add(projeto);
            _bancoContext.SaveChanges();
            return (projeto);
        }

        public ProjetoModel BuscarPorId(int id)
        {
            return _bancoContext.Projetos.FirstOrDefault(x => x.Id == id);
        }

        public List<ProjetoModel> BuscarTodos(int id)
        {
            return _bancoContext.Projetos.Where(x => x.UsuarioId == id).ToList();
        }

        public ProjetoModel Editar(ProjetoModel projeto)
        {
            ProjetoModel projetoDB = BuscarPorId(projeto.Id) ?? throw new System.Exception($"Erro na atualização do Projeto. ID {projeto.Id} não encontrado no banco de dados");
            projetoDB.NomeProjeto = projeto.NomeProjeto;
            projetoDB.Descricao = projeto.Descricao;
            projetoDB.DataInicial = projeto.DataInicial;
            projetoDB.DataFinal = projeto.DataFinal;
            projetoDB.Valor = projeto.Valor;
            
            _bancoContext.Update(projetoDB);
            _bancoContext.SaveChanges();

            return projetoDB;
        }

        public bool Apagar(int id)
        {
            ProjetoModel projetoDB = BuscarPorId(id) ?? throw new System.Exception($"Erro ao excluir o Projeto. ID {id} não encontrado no banco de dados");

            _bancoContext.Projetos.Remove(projetoDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }

}