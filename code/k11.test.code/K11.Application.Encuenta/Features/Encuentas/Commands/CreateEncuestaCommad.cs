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
    public class CreateEncuestaCommad : IRequest<Response<int>>
    {
        public string Descripcion { get; set; }
        public int UsuarioCrea { get; set; }
        public List<PreguntasEncuestaRequest> PreguntasEncuestas { get; set; }
    }
    public class CreateEncuestaCommadHandler : IRequestHandler<CreateEncuestaCommad, Response<int>>
    {
        private readonly IEncuestaRepository _encuestaRepository;
        private readonly IMapper _mapper;
        public CreateEncuestaCommadHandler(IEncuestaRepository encuestaRepository, IMapper mapper)
        {
            _encuestaRepository = encuestaRepository;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(CreateEncuestaCommad request, CancellationToken cancellationToken)
        {
            if (request.UsuarioCrea!=1)
            {
                throw new KeyNotFoundException($"No esta permitido a realizar esta operacion, usted no es el administrador");
            }
            var encuesta = _mapper.Map<Encuestas>(request);
            var data = await _encuestaRepository.Add(encuesta);
            return new Response<int>(data.IdEncuesta);
        }
    }
}
