using System;
using PUConstruir.Models;


namespace PUConstruir.Repositorio
{
    public interface IServicoRepositorio
    {
        List<ServicoModel> BuscarTodos(int id);

        ServicoModel BuscarPorId(int id);

        ServicoModel Criar(ServicoModel servico);

        ServicoModel Editar(ServicoModel servico);

        bool Deletar(int id);

    }
}