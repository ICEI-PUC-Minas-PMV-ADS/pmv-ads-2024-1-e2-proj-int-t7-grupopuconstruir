using System.ComponentModel.DataAnnotations;

namespace PUConstruir.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o email do usuário")]
        [EmailAddress(ErrorMessage = "O email informado não é válido!")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Digite a senha do usuário")]
        public required string Senha { get; set; }
    }
}
