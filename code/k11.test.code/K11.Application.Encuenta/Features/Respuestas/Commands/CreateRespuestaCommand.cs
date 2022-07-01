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

namespace K11.Application.Encuenta.Features.Respuestas.Commands
{
    public class CreateRespuestaCommand : IRequest<Response<bool>>
    {
        public int UsuarioCrea { get; set; }
        public List<RespuestaEncuestaRequest> RespuestaEncuesta { get; set; }
    }
    public class CreateRespuestaCommandHandler : IRequestHandler<CreateRespuestaCommand, Response<bool>>
    {
        private readonly IRespuestasEncuestaRepository _respuestasEncuestaRepository;
        private readonly IMapper _mapper;
        public CreateRespuestaCommandHandler(IRespuestasEncuestaRepository respuestasEncuestaRepository, IMapper mapper)
        {
            _respuestasEncuestaRepository = respuestasEncuestaRepository;
            _mapper = mapper;
        }

        public async Task<Response<bool>> Handle(CreateRespuestaCommand request, CancellationToken cancellationToken)
        {
            var respuestas = _mapper.Map<List<RespuestasEncuestas>>(request.RespuestaEncuesta);
            var data = await _respuestasEncuestaRepository.Add(respuestas, request.UsuarioCrea);
            if (!data)
            {
                throw new FormatException($"Las preguntas ha contestar no son validas o existentes en la encuesta");
            }            
            return new Response<bool>(data);
        }
    }
}
