using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PUConstruir.Repositorio
{
    public interface IProjetoRepositorio
    {
        List<ProjetoModel> BuscarTodos()
        ProjetoModel Adicionar(ProjetoModel projeto)
    }
   
}