using AutoMapper;
using K11.Application.Encuenta.DTOs;
using K11.Application.Encuenta.Wrappers;
using K11.Repository.Encuenta.Entities;
using K11.Repository.Encuenta.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace K11.Application.Encuenta.Features.Encuentas.Commands
{
    public class UpdateEncuestaCommad : IRequest<Response<int>>
    {
        public int IdEncuesta { get; set; }
        public string Descripcion { get; set; }
        public int UsuarioModifica { get; set; }
        public List<PreguntasEncuestaDto> PreguntasEncuestas { get; set; }
    }
    public class UpdateEncuestaCommadHandler : IRequestHandler<UpdateEncuestaCommad, Response<int>>
    {
        private readonly IEncuestaRepository _encuestaRepository;
        private readonly IRespuestasEncuestaRepository _respuestasEncuestaRepository;
        private readonly IMapper _mapper;

        public UpdateEncuestaCommadHandler(IEncuestaRepository encuestaRepository, IMapper mapper, IRespuestasEncuestaRepository respuestasEncuestaRepository)
        {
            _encuestaRepository = encuestaRepository;
            _mapper = mapper;
            _respuestasEncuestaRepository = respuestasEncuestaRepository;
        }

        public async Task<Response<int>> Handle(UpdateEncuestaCommad request, CancellationToken cancellationToken)
        {
            if (request.UsuarioModifica != 1)
            {
                throw new KeyNotFoundException($"No esta permitido a realizar esta operacion, usted no es el administrador");
            }
            var encuestas = _encuestaRepository.FindById(request.IdEncuesta);
            if (encuestas == null)
            {
                throw new KeyNotFoundException($"Registro no encontrado con el id {request.IdEncuesta}");
            }
            else
            {
                var rule = _respuestasEncuestaRepository.Exits(request.IdEncuesta);
                if (rule)
                {
                    throw new KeyNotFoundException($"La encuesta ya cuenta con respuestas realizadas no puede editarlos");
                }
                else
                {
                    encuestas.Descripcion = request.Descripcion;
                    encuestas.UsuarioModifica = request.UsuarioModifica;
                    var preguntas = _mapper.Map<List<PreguntasEncuestas>>(request.PreguntasEncuestas);
                    await _encuestaRepository.Update(encuestas, preguntas);
                    return new Response<int>(encuestas.IdEncuesta);
                }
                
            }
        }
    }
}
