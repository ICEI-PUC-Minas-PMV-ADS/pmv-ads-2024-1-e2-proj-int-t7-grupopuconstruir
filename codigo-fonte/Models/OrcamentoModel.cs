using System.ComponentModel.DataAnnotations;

namespace PUConstruir.Models
{
    public class OrcamentoModel
    {
        [Required(ErrorMessage = "Digite o nome do orçamento")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Digite o valor total do orçamento")]
        public required decimal ValorTotal {  get; set; }

        public DateOnly DataCriacao { get; set; }

        public OrcamentoModel()
        {
            DataCriacao = DateOnly.FromDateTime(DateTime.Now);
        }
    }
}
