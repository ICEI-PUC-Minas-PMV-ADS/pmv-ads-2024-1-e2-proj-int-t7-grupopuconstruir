namespace PUConstruir.Models
{
    public class ServicoModel
    {
        public required int Id { get; set; }
        public string Descricao { get; set; }
        public string Um { get; set; }
        public decimal ValorPadrao { get; set; }
        public DateOnly DataCriacao { get; set; }

        public ServicoModel()
        {
            DataCriacao = DateOnly.FromDateTime(DateTime.Now);
        }


    }
}
