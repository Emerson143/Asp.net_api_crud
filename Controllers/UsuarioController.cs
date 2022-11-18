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

        UsuarioController(IUusuarioRepository repository)
          {
            _repository = repository;
        }


        [HttpGet]

        public IActionResult Get() 
        {
            return Ok(Usuarios());
        }

        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            var usuarios = Usuarios();
            usuarios.add(usuario);
            return Ok(usuario);
        }

    }
}