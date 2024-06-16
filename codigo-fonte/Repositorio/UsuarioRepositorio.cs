using Microsoft.EntityFrameworkCore;
using PUConstruir.Data;
using PUConstruir.Models;

namespace PUConstruir.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {

        private readonly BancoContext _bancoContext;
        public UsuarioRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public UsuarioModel Adicionar(UsuarioModel usuario)
        {
            usuario.DataCriacao = DateOnly.FromDateTime(DateTime.Now);
            usuario.CriptografiaSenha();
            _bancoContext.Usuarios.Add(usuario);
            _bancoContext.SaveChanges();
            return usuario;
        }

        public UsuarioModel ValidarLogin(string email)
        {
            return _bancoContext.Usuarios.FirstOrDefault(x => x.Email.ToUpper() == email.ToUpper());
        }

        public UsuarioModel BuscarPorId(int id)
        {
            return _bancoContext.Usuarios.FirstOrDefault(x => x.Id == id);
        }

        public List<UsuarioModel> BuscarTodos()
        {
            return _bancoContext.Usuarios
                .Include(x => x.Materiais)
                .Include(x => x.Servicos)
                .Include(x => x.Projetos)
                .Include(x => x.Orcamentos)
                .ToList();
        }
        public UsuarioModel Editar(UsuarioModel usuario)
        {
            UsuarioModel usuarioDB = BuscarPorId(usuario.Id);

            if (usuarioDB == null) throw new Exception("Houve um erro na atualização do usuário!");

            usuarioDB.Nome = usuario.Nome;
            usuarioDB.Email = usuario.Email;

            _bancoContext.Usuarios.Update(usuarioDB);
            _bancoContext.SaveChanges();

            return usuarioDB;
        }

        public bool Apagar(int id)
        {
            UsuarioModel usuarioDB = BuscarPorId(id) ?? throw new System.Exception($"Erro ao excluir o Usuario. ID {id} não encontrado no banco de dados");

            // Excluir todos os orçamentos do usuário
            _bancoContext.Orcamentos.RemoveRange(_bancoContext.Orcamentos.Where(o => o.UsuarioId == usuarioDB.Id));

            // Excluir todos os projetos do usuário
            _bancoContext.Projetos.RemoveRange(_bancoContext.Projetos.Where(p => p.UsuarioId == usuarioDB.Id));

            // Excluir todos os materiais do usuário
            _bancoContext.Materiais.RemoveRange(_bancoContext.Materiais.Where(m => m.UsuarioId == usuarioDB.Id));

            // Excluir todos os serviços do usuário
            _bancoContext.Servicos.RemoveRange(_bancoContext.Servicos.Where(s => s.UsuarioId == usuarioDB.Id));            

            // Excluir o usuário
            _bancoContext.Usuarios.Remove(usuarioDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
