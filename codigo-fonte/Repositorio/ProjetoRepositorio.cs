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

        public List<ProjetoModel> BuscarTodos()
        {
            return _bancoContext.Projetos.ToList();
        }

    }

}