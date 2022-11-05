using Asp.net_api_crud.model;
using Microsoft.AspNetCore.Mvc;


namespace Asp.net_api_crud.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private static List<Usuario> Usuarios()
        {
            return new List<Usuario>{
                new Usuario{ nome = "Emerson", id = 1 , dataMascimento = new DateTime(1998,09,14)}
            };
        }



        [HttpGet]

        public IActionResult Get()
        {
            return Ok(Usuarios());
        }

       

    }
}