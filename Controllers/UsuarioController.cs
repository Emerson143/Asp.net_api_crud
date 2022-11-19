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

        [HttpPost]
        public async Task<IActionResult> Post(Usuario usuario)
        {
            _repository.AdicionaUsuario(usuario);
            return await _repository.SaveChangesAsync()
             ? Ok("usuário Adicionado com sucesso")
             : BadRequest("Erro ao salvar usuário");
        }

    }
}