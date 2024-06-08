using System.ComponentModel.DataAnnotations;

namespace PUConstruir.Models
{
    public class RecuperarSenhaModel
    {
        [Required(ErrorMessage = "Digite o email do usuário")]
        [EmailAddress(ErrorMessage = "O email informado não é válido!")]
        public required string Email { get; set; }
    }
}
