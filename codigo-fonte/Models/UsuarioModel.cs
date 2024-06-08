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

        public DateOnly DataCriacao { get; set; }

        //------ Relacionamento entre tabelas ------
        public virtual List<MaterialModel> Materiais { get; set; } = new List<MaterialModel>();
        public virtual List<ServicoModel> Servicos { get; set; } = new List<ServicoModel>();
        public virtual List<ProjetoModel> Projetos { get; set; } = new List<ProjetoModel>();
        public virtual List<OrcamentoModel> Orcamentos { get; set; } = new List<OrcamentoModel>();


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

        public string gerarNovaSenha()
        {
            string novaSenha = Guid.NewGuid()
                .ToString()
                .Substring(0, 8);
            Senha = novaSenha.gerarHash();
            return novaSenha;
        }
    }
}
