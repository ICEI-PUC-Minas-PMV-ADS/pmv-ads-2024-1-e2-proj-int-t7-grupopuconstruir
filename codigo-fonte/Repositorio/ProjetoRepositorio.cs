using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        ProjetoModel Adicionar(ProjetoModel projeto)
        {
            _bancoContext.Projetos.Add(projeto);
            _bancoContext.SaveChanges;

            return projeto;
        }

        public List<ProjetoModel> BuscarTodos()
        {
            return _bancoContext.Projetos.ToList();
        }

        
    }

}