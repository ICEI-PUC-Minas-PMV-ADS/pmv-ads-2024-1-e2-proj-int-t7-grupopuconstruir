using System;
using PUConstruir.Controllers;
using PUConstruir.Repositorio;
using Microsoft.Identity.Client;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PUConstruir.Models
{
    public class ProjetoModel
    {

        public int Id { get; set; }
        public string NomeProjeto { get; set; }
        public string? Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateOnly? DataInicial { get; set; }
        public DateOnly? DataFinal { get; set; }
        public DateOnly DataCriacao { get; set; }

        //------ Relacionamento entre tabelas ------
        public int? UsuarioId { get; set; }
        public UsuarioModel Usuario { get; set; }

        public ICollection<MaterialModel> Materiais { get; set; } = new List<MaterialModel>();
        public ICollection<ServicoModel> Servicos { get; set; } = new List<ServicoModel>();
    }
}
