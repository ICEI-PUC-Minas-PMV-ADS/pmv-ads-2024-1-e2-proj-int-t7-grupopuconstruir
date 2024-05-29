using System;
using PUConstruir.Models;


namespace PUConstruir.Repositorio
{
    public interface IProjetoRepositorio
    {
        ProjetoModel Adicionar(ProjetoModel projeto);

        List<ProjetoModel> BuscarTodos();
    }

}