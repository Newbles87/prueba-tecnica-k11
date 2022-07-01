using K11.Application.Encuenta.Features.Respuestas.Commands;
using K11.Application.Encuenta.Features.Respuestas.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace K11.MS.Encuentas.Controllers.v1
{
    [ApiVersion("1.0")]
    public class RespuestasController : BaseApiController
    {
        
        [HttpPost]
        public async Task<IActionResult> Post(CreateRespuestaCommand commad)
        {
            return Ok(await Mediator.Send(commad));
        }
        [HttpGet("estadistica")]
        public async Task<IActionResult> GetStadistic()
        {
            return Ok(await Mediator.Send(new RespuestasEstadisticaQuery()));
        }
    }
}
