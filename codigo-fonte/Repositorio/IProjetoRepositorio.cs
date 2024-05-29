using System;
using PUConstruir.Models;


namespace PUConstruir.Repositorio
{
    public interface IProjetoRepositorio
    {
        List<ProjetoModel> BuscarTodos();

        ProjetoModel Adicionar(ProjetoModel projeto);
        void Adicionar();
    }

}