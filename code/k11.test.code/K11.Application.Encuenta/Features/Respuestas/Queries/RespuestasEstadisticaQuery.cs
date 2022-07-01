using AutoMapper;
using K11.Application.Encuenta.DTOs;
using K11.Application.Encuenta.Wrappers;
using K11.Repository.Encuenta.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace K11.Application.Encuenta.Features.Respuestas.Queries
{
    public class RespuestasEstadisticaQuery : IRequest<Response<List<EstadisticaRespuestaDto>>>
    {        
    }
    public class RespuestasEstadisticaQueryHandler : IRequestHandler<RespuestasEstadisticaQuery, Response<List<EstadisticaRespuestaDto>>>
    {
        private readonly IRespuestasEncuestaRepository _respuestasEncuestaRepository;
        private readonly IMapper _mapper;
        public RespuestasEstadisticaQueryHandler(IRespuestasEncuestaRepository respuestasEncuestaRepository, IMapper mapper)
        {
            _respuestasEncuestaRepository = respuestasEncuestaRepository;
            _mapper = mapper;
        }

        public async Task<Response<List<EstadisticaRespuestaDto>>> Handle(RespuestasEstadisticaQuery respuestas, CancellationToken cancellationToken)
        {            
            var data = _respuestasEncuestaRepository.Stadistic();
            if (!data.Any())
            {
                throw new FormatException($"No existen respuesta para alguna encuesta, por ende no existe estadistica que generar");
            }
            var result = _mapper.Map<List<EstadisticaRespuestaDto>>(data);
            return new Response<List<EstadisticaRespuestaDto>>(result);
        }

      
    }
}
