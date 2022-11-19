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

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            var usuario = modelBuilder.Entity<Usuario>();

            usuario.ToTable("tb_usuario");
            usuario.HasKey(x => x.id);
            usuario.Property(x => x.id).HasColumnName("id").ValueGeneratedOnAdd();
            usuario.Property(x => x.nome).HasColumnName("nome").IsRequired();
            usuario.Property(x => x.dataNascimento).HasColumnName("data_nascimento");


        }

        
    }
}