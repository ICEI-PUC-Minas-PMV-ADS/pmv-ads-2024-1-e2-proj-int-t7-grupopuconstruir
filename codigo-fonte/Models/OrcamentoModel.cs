using System.ComponentModel.DataAnnotations;

namespace PUConstruir.Models
{
    public class OrcamentoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do orçamento")]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "Digite o valor total do orçamento")]
        public required decimal ValorTotal {  get; set; }

        public DateOnly DataCriacao { get; set; }

        public OrcamentoModel()
        {
            DataCriacao = DateOnly.FromDateTime(DateTime.Now);
        }

        //------ Relacionamento entre tabelas ------
        public int? UsuarioId { get; set; }

        public UsuarioModel Usuario { get; set; }
    }
}
