using Microsoft.Identity.Client;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PUConstruir.Models
{
    public class MaterialModel
    {
        public int Id  { get; set; }

        [Required(ErrorMessage = "Digite a Descrição do Material")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Digite a Unidade de Medida do Material")]
        public string Um { get; set; }

        [Required(ErrorMessage = "Digite o Preço Padrão do Material (Se não souber, digite o número zero")]
        public decimal ValorPadrao { get; set; }
        
        public decimal Altura { get; set; }

        public decimal Largura { get; set; }

        public decimal Comprimento { get; set; }

        public decimal Peso { get; set; }

        public string Cor { get; set; }
        
        public DateOnly DataCriacao { get; set; }

        //------ Relacionamento entre tabelas ------
        public int? UsuarioId { get; set; }
        public UsuarioModel Usuario { get; set; }

        public ICollection<ProjetoModel> Projetos { get; set; } = new List<ProjetoModel>();

    }
}
