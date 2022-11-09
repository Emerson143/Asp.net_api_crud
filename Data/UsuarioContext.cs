using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp.net_api_crud.model;

namespace Asp.net_api_crud.Data

{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext(DbContextOptions <UsuarioContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios {get; set;}
    }
}