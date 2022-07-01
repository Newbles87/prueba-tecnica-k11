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

namespace K11.Application.Encuenta.Features.Encuentas.Queries
{
    public class EncuestaGetByIdQuery: IRequest<Response<EncuestaDto>>
    {
        public int Id { get; set; }
    }

    public class EncuestaGetByIdQueryHandler : IRequestHandler<EncuestaGetByIdQuery, Response<EncuestaDto>>
    {
        private readonly IEncuestaRepository _encuestaRepository;
        private readonly IMapper _mapper;

        public EncuestaGetByIdQueryHandler(IEncuestaRepository encuestaRepository, IMapper mapper)
        {
            _encuestaRepository = encuestaRepository;
            _mapper = mapper;
        }
        public async Task<Response<EncuestaDto>> Handle(EncuestaGetByIdQuery request, CancellationToken cancellationToken)
        {
            var encuesta = _encuestaRepository.FindById(request.Id);
            if (encuesta == null)
            {
                throw new KeyNotFoundException($"Registro no encontrado con el id {request.Id}");
            }
            else
            {                
                var data = _mapper.Map<EncuestaDto>(encuesta);
                return new Response<EncuestaDto>(data);
            }
        }
    }
}
