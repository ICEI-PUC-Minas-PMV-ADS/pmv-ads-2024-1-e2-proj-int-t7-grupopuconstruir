using PUConstruir.Helper;
using System.ComponentModel.DataAnnotations;

namespace PUConstruir.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do usuário")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o email do usuário")]
        [EmailAddress(ErrorMessage = "O email informado não é válido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite o telefone do usuário")]
        [Phone(ErrorMessage = "O telefone informado não é válido!")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Digite a senha do usuário")]
        public string Senha { get; set; }

        //Adicionar data de criação automaticamente
        public DateOnly DataCriacao { get; set; }
        public UsuarioModel()
        {
            DataCriacao = DateOnly.FromDateTime(DateTime.Now);
        }

        //------ Validações adicionais ------
        //Verificar se a senha é válida
        public bool SenhaValida(string senha)
        {
            return (Senha == senha.gerarHash());
        }
        //Criptografar senha
        public void CriptografiaSenha()
        {
            Senha = Senha.gerarHash();
        }
    }
}
