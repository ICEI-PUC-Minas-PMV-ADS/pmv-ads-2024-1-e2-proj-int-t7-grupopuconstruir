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
        public virtual List<MaterialModel> Materiais { get; set; }
        public virtual List<ServicoModel> Servicos { get; set; }
        public virtual List<ProjetoModel> Projetos { get; set; }
        public virtual List<OrcamentoModel> Orcamentos { get; set; }

        public UsuarioModel()
        {
            Materiais = new List<MaterialModel>();
            Servicos = new List<ServicoModel>();
            Projetos = new List<ProjetoModel>();
            Orcamentos = new List<OrcamentoModel>();
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
