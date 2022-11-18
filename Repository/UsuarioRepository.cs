using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.net_api_crud.Controllers;
using Asp.net_api_crud.Data;
using Asp.net_api_crud.model;

namespace Asp.net_api_crud.Repository
{
    public class NewBaseType
    {
        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }

    public class UsuarioRepository : IUusuarioRepository
{
    private readonly UsuarioController _context;

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

    public Task<IEnumerable<Usuario>> BuscaUsuario()
    {
        throw new NotImplementedException();
    }

    public Task<Usuario> BuscaUsuario(int id)
    {
        throw new NotImplementedException();
    }

    public void DeletaUsuario(Usuario usuario)
    {
        throw new NotImplementedException();
    }

        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}

