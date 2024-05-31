using PUConstruir.Data;
using PUConstruir.Helper;
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
            material.DataCriacao = DateOnly.FromDateTime(DateTime.Now);
            _bancoContext.Materiais.Add(material);
            _bancoContext.SaveChanges();

            return material;

        }

        public MaterialModel BuscarPorId(int id)
        {
            return _bancoContext.Materiais.FirstOrDefault(x => x.Id == id);
        }

        public List<MaterialModel> BuscarTodos(int id)
        {
            return _bancoContext.Materiais.Where(x => x.UsuarioId == id).ToList();
        }

        public MaterialModel Atualizar(MaterialModel material)
        {
            MaterialModel materialDB = BuscarPorId(material.Id) ?? throw new System.Exception($"Erro na atualização do Material. ID {material.Id} não encontrado no DB");
           
            materialDB.Descricao = material.Descricao;
            materialDB.Um = material.Um;
            materialDB.ValorPadrao = material.ValorPadrao;
            materialDB.Altura = material.Altura;
            materialDB.Largura = material.Largura;
            materialDB.Comprimento = material.Comprimento;
            materialDB.Peso = material.Peso;
            materialDB.Cor = material.Cor;

            _bancoContext.Update(materialDB);
            _bancoContext.SaveChanges();
            
            return materialDB;
        }

        public bool Apagar(int id)
        {
            MaterialModel materialDB = BuscarPorId(id) ?? throw new System.Exception($"Erro ao tentar deletar o Material. ID {id} não encontrado no DB");

            _bancoContext.Materiais.Remove(materialDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
