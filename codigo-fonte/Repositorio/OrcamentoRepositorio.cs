using Microsoft.EntityFrameworkCore;
using PUConstruir.Data;
using PUConstruir.Models;

namespace PUConstruir.Repositorio
{
    public class OrcamentoRepositorio : IOrcamentoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public OrcamentoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public OrcamentoModel Adicionar(OrcamentoModel orcamento)
        {
            // Calcular o valor total dos projetos
            orcamento.CalcularValorTotal();

            //Adicionar a data da criação do item
            orcamento.DataCriacao = DateOnly.FromDateTime(DateTime.Now);

            // Adiciona o projeto ao banco de dados
            _bancoContext.Orcamentos.Add(orcamento);

            // Salva as mudanças antes de adicionar os materiais
            _bancoContext.SaveChanges();

            return orcamento;
        }

        public OrcamentoModel Editar(OrcamentoModel orcamento)
        {
            var orcamentoDB = _bancoContext.Orcamentos
                .Include(o => o.Projetos)
                .FirstOrDefault(o => o.Id == orcamento.Id) ?? throw new Exception($"Erro na atualização do Orçamento. ID {orcamento.Id} não encontrado no banco de dados");

            orcamentoDB.Nome = orcamento.Nome;

            // Atualiza a relação many-to-many para Projetos
            orcamentoDB.Projetos.Clear();
            foreach (var projeto in orcamento.Projetos)
            {
                var existingProjeto = _bancoContext.Projetos.Find(projeto.Id);
                if (existingProjeto != null)
                {
                    orcamentoDB.Projetos.Add(existingProjeto);
                }
            }

            orcamentoDB.CalcularValorTotal();

            _bancoContext.Update(orcamentoDB);
            _bancoContext.SaveChanges();

            return orcamentoDB;
        }


        public bool Apagar(int id)
        {
            OrcamentoModel orcamentoDB = BuscarPorId(id) ?? throw new System.Exception($"Erro ao tentar deletar o Orçamento. ID {id} não encontrado no banco de dados");

            _bancoContext.Orcamentos.Remove(orcamentoDB);
            _bancoContext.SaveChanges();

            return true;
        }

        public OrcamentoModel BuscarPorId(int id)
        {
            return _bancoContext.Orcamentos
                .Include(o => o.Projetos)
                    .ThenInclude(p => p.Materiais)
                .Include(o => o.Projetos)
                    .ThenInclude(p => p.Servicos)
                .FirstOrDefault(x => x.Id == id);
        }

        public List<OrcamentoModel> BuscarTodos(int id)
        {
            return _bancoContext.Orcamentos.Where(x => x.UsuarioId == id).ToList();
        }
    }
}
