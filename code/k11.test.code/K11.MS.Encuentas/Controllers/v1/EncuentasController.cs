using K11.Application.Encuenta.DTOs;
using K11.Application.Encuenta.Features.Encuentas.Commands;
using K11.Application.Encuenta.Features.Encuentas.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace K11.MS.Encuentas.Controllers.v1
{
    [ApiVersion("1.0")]
    public class EncuentasController : BaseApiController
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await Mediator.Send(new EncuestaGetByIdQuery { Id = id }));
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateEncuestaCommad commad)
        {
            return Ok(await Mediator.Send(commad));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteEncuestaCommad { Id = id }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, EncuestaRequest request)
        {
            return Ok(await Mediator.Send(new UpdateEncuestaCommad { IdEncuesta = id,
                                                                    Descripcion = request.Descripcion,
                                                                    UsuarioModifica = request.UsuarioModifica,
                                                                    PreguntasEncuestas=request.PreguntasEncuestas }));
        }
    }
}
