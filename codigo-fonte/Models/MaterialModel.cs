using System;

namespace PUConstruir.Models
{
    public class MaterialModel
    {
        private int _Id;
        private string _Descricao = string.Empty;
        private string _Um = string.Empty;
        private decimal _valorPadrao;
        private decimal _Altura;
        private decimal _Largura;
        private decimal _Comprimento;
        private decimal _Peso;
        private string _Cor = string.Empty;
        private DateOnly _DataCriacao;
        //private UsuarioModel _Usuario;

        public int Id { get => _Id; set => _Id = value; }

        public string Descricao { get => _Descricao; set => _Descricao = value; }
        
        public string Um { get => _Um; set => _Um = value; }
        
        public decimal ValorPadrao { get => _valorPadrao; set => _valorPadrao = value; }

        public decimal Altura { get => _Altura; set => _Altura = value; }

        public decimal Largura { get => _Largura; set => _Largura = value; }

        public decimal Comprimento { get => _Comprimento; set => _Comprimento = value; }

        public decimal Peso { get => _Peso; set => _Peso = value; }

        public string Cor { get => _Cor; set => _Cor = value; }
        
        public DateOnly DataCriacao { get => _DataCriacao; set => _DataCriacao = value; }

        public UsuarioModel Usuario { get; set; }

        public int? UsuarioId { get; set; }

        public MaterialModel()
        {
            DataCriacao = DateOnly.FromDateTime(DateTime.Now);
        }
    }
}
