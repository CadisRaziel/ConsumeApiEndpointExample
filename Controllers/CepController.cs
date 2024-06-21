using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Src.Core.Interfaces;
using Src.Core.Response;

namespace Src.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CepController : ControllerBase
    {
        private readonly IViaCepIntegration _viaCepIntegration;

        public CepController(IViaCepIntegration viaCepIntegration)
        {
            _viaCepIntegration = viaCepIntegration;
        }

        [HttpGet("{cep}")]
        public async Task<ActionResult<ViaCepResponse>> GetAdress(string cep)
        {
            var response = await _viaCepIntegration.GetDataViaCep(cep);

            if (response is null) { 
                return BadRequest("Cep nao encontrado");
            }

            return Ok(response);
        }
    }
}
