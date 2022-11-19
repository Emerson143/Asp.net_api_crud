using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.net_api_crud.model;

namespace Asp.net_api_crud.Repository
{
public interface IUusuarioRepository
{
    Task<IEnumerable<Usuario>> BuscaUsuarios();
    Task<Usuario> BuscaUsuario(int id);
    void AdicionaUsuario (Usuario usuario);
    void AtualizaUsuario (Usuario usuario);
    void DeletaUsuario (Usuario usuario);

    Task<bool> SaveChangesAsync();

}
}
