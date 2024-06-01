using System;
using PUConstruir.Controllers;
using PUConstruir.Repositorio;

namespace PUConstruir.Models
{
    public class ServicoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal ValorPadrao { get; set; }
        public DateOnly DataCriacao { get; set; }


        //Relacionamento entre tabelas
        public int? UsuarioId { get; set; }
        public UsuarioModel Usuario { get; set; }

        public ICollection<ProjetoModel> Projetos { get; set; } = new List<ProjetoModel>();
    }
}