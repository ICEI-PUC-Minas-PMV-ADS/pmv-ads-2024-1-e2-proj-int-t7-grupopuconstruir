using PUConstruir.Data;
using PUConstruir.Models;

namespace PUConstruir.Repositorio
{
    public class MaterialRepositorio : IMaterialRepositorio
    {   
        private readonly BancoContext _bancoContext;
        public MaterialRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }


        public MaterialModel Adicionar(MaterialModel material)
        {
            _bancoContext.Materiais.Add(material);
            _bancoContext.SaveChanges();
            
            return material;
            
        }

        public List<MaterialModel> BuscarTodos()
        {
            return _bancoContext.Materiais.ToList();
        }
    }
}
