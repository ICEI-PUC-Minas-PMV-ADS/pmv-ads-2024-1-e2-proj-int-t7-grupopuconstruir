using System;
using PUConstruir.Controllers;
using PUConstruir.Repositorio;

namespace PUConstruir.Models
{
    public class ServicoModel
    {
        private int _Id;
        private string _Nome = string.Empty;
        private string _Descricao = string.Empty;
        private decimal _ValorPadrao;
        private DateOnly _DataInicial;
        private DateOnly _DataFinal;
        private DateOnly _DataCriacao;

        public int Id { get => _Id; set => _Id = value; }
        public string Nome { get => _Nome; set => Nome = value; }
        public string Descricao { get => _Descricao; set => _Descricao = value; }
        public decimal ValorPadrao { get => _ValorPadrao; set => _ValorPadrao = value; }
        
        
        
        public DateOnly DataCriacao { get; set; }

        public ServicoModel()
        {
            DataCriacao = DateOnly.FromDateTime(DateTime.Now);
        }

        public int? UsuarioId { get; set; }

    }
}
