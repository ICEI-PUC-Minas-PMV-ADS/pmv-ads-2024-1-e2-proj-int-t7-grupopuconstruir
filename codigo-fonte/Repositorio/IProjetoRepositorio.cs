using System;
using PUConstruir.Models;


namespace PUConstruir.Repositorio
{
    public interface IProjetoRepositorio
    {
        ProjetoModel Adicionar(ProjetoModel projeto);

        List<ProjetoModel> BuscarTodos(int id);

        ProjetoModel BuscarPorId(int id);

        ProjetoModel Editar(ProjetoModel material);

        bool Apagar(int id);
    }

}