using System.ComponentModel.DataAnnotations;

namespace PUConstruir.Models
{
    public class UsuarioModel
    {
        [Required(ErrorMessage = "Digite o nome do usuário")]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "Digite o email do usuário")]
        [EmailAddress(ErrorMessage = "O email informado não é válido!")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Digite o telefone do usuário")]
        //[Phone(ErrorMessage = "O telefone informado não é válido!")]
        public required string Telefone { get; set; }

        [Required(ErrorMessage = "Digite a senha do usuário")]
        public required string Senha { get; set; }
        public DateOnly DataCriacao { get; set; }

        public virtual List<MaterialModel> Materiais { get; set; }

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
