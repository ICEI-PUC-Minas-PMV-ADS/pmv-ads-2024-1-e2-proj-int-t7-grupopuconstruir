using System.ComponentModel.DataAnnotations;

namespace PUConstruir.ViewModels
{
    public class AlterarSenhaViewModel
    {
        [Required(ErrorMessage = "Digite a nova senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Nova Senha")]
        public string NovaSenha { get; set; }

        [Required(ErrorMessage = "Confirme a nova senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Nova Senha")]
        [Compare("NovaSenha", ErrorMessage = "A nova senha e a confirmação de senha não coincidem.")]
        public string ConfirmarNovaSenha { get; set; }
    }
}
