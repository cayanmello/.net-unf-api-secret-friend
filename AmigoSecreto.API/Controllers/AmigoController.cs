using AmigoSecreto.API.Models;
using Microsoft.AspNetCore.Mvc;
using AmigoSecreto.API.Services;
using AmigoSecreto.API.ViewModels;
using AmigoSecreto.API.Services.Interfaces;

namespace AmigoSecreto.API.Controllers
{
    public class AmigoController : ControllerBase
    {
        private readonly IAmigoService _service;

        public AmigoController(IAmigoService amigoService)
            => _service = amigoService;
        
        [HttpGet("/v1/buscar-todos")]
        public IActionResult BuscarTodosOsAmigos()
            => Ok(_service.GetAll());

        [HttpGet("/v1/email-existe/{email}")]
        public IActionResult EmailExiste([FromRoute] string email)
            => Ok(_service.GetAll().Any(amigo => amigo.Email == email));

        [HttpGet("v1/buscar-amigo/{id}")]
        public IActionResult Index([FromRoute] string id)
        {
            var amigo = _service.GetById(id);
            return amigo is not null ? 
            Ok(amigo) : NotFound($"Amigo com identificação {id} não foi encontrado.");
        }

        [HttpPost("/v1/registrar")]
        public IActionResult SalvarAmigo([FromBody] CreateAmigoViewModel model)
        {
            if(!ModelState.IsValid)
                return BadRequest("Erro ao criar amigo" + model);

            var amigo = new Amigo(model.Name, model.Email);
            var result = _service.Save(amigo);
            
            if(!result)
                return BadRequest("ACS1 - Erro ao salvar registro.");    

            return Created($"v1/buscar-amigo/{amigo.Id}", result);
        }
    }
}
