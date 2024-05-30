using System;
using PUConstruir.Controllers;
using PUConstruir.Repositorio;
using Microsoft.Identity.Client;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PUConstruir.Models;

    public class ProjetoModel
    {

        private int _Id;
        private string _NomeProjeto = string.Empty;
        private string _Descricao = string.Empty;
        private decimal _Valor;
        private DateOnly _DataInicial;
        private DateOnly _DataFinal;
        private DateOnly _DataCriacao;
    
        public int Id { get => _Id; set => _Id = value; }
        public string NomeProjeto { get => _NomeProjeto; set => _NomeProjeto = value; }
        public string Descricao { get => _Descricao; set => _Descricao = value; }
        public decimal Valor { get => _Valor; set => _Valor = value; }
        public DateOnly DataInicial { get => _DataInicial; set => _DataInicial = value; }
        public DateOnly DataFinal { get => _DataFinal; set => _DataFinal = value; }
        public DateOnly DataCriacao { get => _DataCriacao; set => _DataCriacao = value; }
        public ProjetoModel()
        {
            DataCriacao = DateOnly.FromDateTime(DateTime.Now);
        }

        public int? UsuarioId { get; set; }
}
