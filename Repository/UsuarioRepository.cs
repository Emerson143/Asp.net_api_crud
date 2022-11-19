
using Asp.net_api_crud.Data;
using Asp.net_api_crud.model;
using Microsoft.EntityFrameworkCore;
namespace Asp.net_api_crud.Repository
{
    public class UsuarioRepository : IUusuarioRepository
    {
        private readonly UsuarioContext _context;

        public UsuarioRepository(UsuarioContext context)
        {
            _context = context;
        }
        public void AdicionaUsuario(Usuario usuario)
        {
            _context.Add(usuario);
        }

        public void AtualizaUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Usuario>> BuscaUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public Task<Usuario> BuscaUsuario(int id)
        {
            throw new NotImplementedException();
        }


        public void DeletaUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
