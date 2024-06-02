using PUConstruir.Models;

namespace PUConstruir.ViewModels
{
    public class OrcamentoViewModel
    {
        public OrcamentoModel Orcamento { get; set; }
        public List<ProjetoModel> TodosProjetos { get; set; }
        public List<int> ProjetosSelecionados { get; set; } = new List<int>();
    }
}