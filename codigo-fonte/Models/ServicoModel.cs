namespace PUConstruir.Models
{
    public class ServicoModel
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Descricao { get; set; }
        public required decimal ValorPadrao { get; set; }
        public DateOnly DataCriacao { get; set; }

        public ServicoModel()
        {
            DataCriacao = DateOnly.FromDateTime(DateTime.Now);
        }

        //------ Relacionamento entre tabelas ------
        public int? UsuarioId { get; set; }

        public UsuarioModel Usuario { get; set; }
    }
}
