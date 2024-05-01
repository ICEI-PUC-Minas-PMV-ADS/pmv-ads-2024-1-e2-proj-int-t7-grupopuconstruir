using System;

namespace PUConstruir.Models
{
    public class MaterialModel
    {
        public int Id { get; set; }
        
        public string Descricao { get; set; } = string.Empty;
        
        public string Um {  get; set; } = string.Empty ;

        public decimal ValorPadrao { get; set; }

        public decimal Altura { get; set; }

        public decimal Largura { get; set; }

        public decimal Comprimento { get; set; }

        public decimal Peso { get; set; }

        public string Cor { get; set; } = string.Empty;

        public DateOnly DataCriacao { get; set; }

        public string Usuario { get; set; } = string.Empty; // Fazer relacionamento com Usuário quando criar esta classe

        public MaterialModel()
        {
            DataCriacao = DateOnly.FromDateTime(DateTime.Now);
        }
    }
}
