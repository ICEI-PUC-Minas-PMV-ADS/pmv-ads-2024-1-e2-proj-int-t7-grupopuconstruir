using PUConstruir.Models;

namespace PUConstruir.ViewModels
{
    public class ProjetoViewModel
    {
        public ProjetoModel Projeto { get; set; }
        public List<MaterialModel> TodosMateriais { get; set; }
        public List<int> MateriaisSelecionados { get; set; } = new List<int>();
        public List<ServicoModel> TodosServicos { get; set; }
        public List<int> ServicosSelecionados { get; set; } = new List<int>();
    }
}
