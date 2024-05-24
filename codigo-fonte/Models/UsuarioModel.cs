using System.ComponentModel.DataAnnotations;

namespace PUConstruir.Models
{
    public class UsuarioModel
    {
        [Required(ErrorMessage = "Digite o nome do usuário")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Digite o email do usuário")]
        [EmailAddress(ErrorMessage = "O email informado não é válido!")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Digite o telefone do usuário")]
        public string Telefone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Digite a senha do usuário")]
        public string Senha { get; set; } = string.Empty;

        public DateOnly DataCriacao { get; set; }

        //public List<MaterialModel >Materiais { get; set; } = new List<MaterialModel>();

        public UsuarioModel()
        {
            DataCriacao = DateOnly.FromDateTime(DateTime.Now);
        }

        public bool SenhaValida(string senha)
        {
            return (Senha == senha);
        }

        private int _Id;

        public int Id { get => _Id; set => _Id = value; }
    }
}
