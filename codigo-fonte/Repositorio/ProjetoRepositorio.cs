using System;
using System.Collections.Generic;
using System.Linq;
using PUConstruir.Repositorio;
using PUConstruir.Data;
using PUConstruir.Helper;
using PUConstruir.Models;
using Microsoft.EntityFrameworkCore;

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
            projeto.DataCriacao = DateOnly.FromDateTime(DateTime.Now);

            // Adiciona o projeto ao banco de dados
            _bancoContext.Projetos.Add(projeto);

            // Salva as mudanças antes de adicionar os materiais
            _bancoContext.SaveChanges();

            return projeto;
        }

        public ProjetoModel BuscarPorId(int id)
        {
            return _bancoContext.Projetos
                .Include(p => p.Materiais)
                .Include(p => p.Servicos)
                .FirstOrDefault(x => x.Id == id);;
        }

        public List<ProjetoModel> BuscarTodos(int id)
        {
            return _bancoContext.Projetos
                .Include(p => p.Materiais)
                .Include(p => p.Servicos)
                .Where(x => x.UsuarioId == id)
                .ToList();
        }

        public ProjetoModel Editar(ProjetoModel projeto)
        {
            var projetoDB = _bancoContext.Projetos
                .Include(p => p.Materiais)
                .Include(p => p.Servicos)
                .FirstOrDefault(p => p.Id == projeto.Id) ?? throw new Exception($"Erro na atualização do Projeto. ID {projeto.Id} não encontrado no banco de dados");

            projetoDB.NomeProjeto = projeto.NomeProjeto;
            projetoDB.Descricao = projeto.Descricao;
            projetoDB.DataInicial = projeto.DataInicial;
            projetoDB.DataFinal = projeto.DataFinal;
            projetoDB.Valor = projeto.Valor;

            // Atualiza a relação many-to-many para Materiais
            projetoDB.Materiais.Clear();
            foreach (var material in projeto.Materiais)
            {
                var existingMaterial = _bancoContext.Materiais.Find(material.Id);
                if (existingMaterial != null)
                {
                    projetoDB.Materiais.Add(existingMaterial);
                }
            }

            // Atualiza a relação many-to-many para Serviços
            projetoDB.Servicos.Clear();
            foreach (var servico in projeto.Servicos)
            {
                var existingServico = _bancoContext.Servicos.Find(servico.Id);
                if (existingServico != null)
                {
                    projetoDB.Servicos.Add(existingServico);
                }
            }

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