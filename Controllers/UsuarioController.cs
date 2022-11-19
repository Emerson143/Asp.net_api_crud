using Asp.net_api_crud.Data;
using Asp.net_api_crud.model;
using Asp.net_api_crud.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Asp.net_api_crud.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUusuarioRepository _repository;

        public UsuarioController(IUusuarioRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            var usuarios = await _repository.BuscaUsuarios();

            return usuarios.Any()
            ? Ok(usuarios)
            : NoContent();

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) 
        {
            var usuario = await _repository.BuscaUsuario(id);

            return usuario != null
            ? Ok(usuario)
            : NotFound("Usuario não encontrado");

        }


        [HttpPost]
        public async Task<IActionResult> Post(Usuario usuario)
        {
            _repository.AdicionaUsuario(usuario);
            return await _repository.SaveChangesAsync()
             ? Ok("usuário Adicionado com sucesso")
             : BadRequest("Erro ao salvar usuário");
        }

        [HttpPut("{id^}")]
            public async Task<IActionResult> Put(int id, Usuario usuario)
            {
                var usuarioBanco = await _repository.BuscaUsuario(id);
                if(usuarioBanco == null)
                    NotFound("Usuario não encontrado");

                   usuarioBanco.nome = usuario.nome ?? usuarioBanco.nome;
                   usuarioBanco.dataNascimento = usuario.dataNascimento != new DateTime()
                   ? usuario.dataNascimento : usuarioBanco.dataNascimento;

                   _repository.AtualizaUsuario(usuarioBanco);

                     return await _repository.SaveChangesAsync()
             ? Ok("usuário atualizado com sucesso")
             : BadRequest("Erro ao atualizar usuário");


                
            }
    }
}