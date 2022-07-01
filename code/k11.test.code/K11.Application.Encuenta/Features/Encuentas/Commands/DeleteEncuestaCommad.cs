using AutoMapper;
using K11.Application.Encuenta.Wrappers;
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
    public class DeleteEncuestaCommad: IRequest<Response<int>>
    {
        public int Id { get; set; }
    }
    public class DeleteEncuestaCommadHandler : IRequestHandler<DeleteEncuestaCommad, Response<int>>
    {
        private readonly IEncuestaRepository _encuestaRepository;        

        public DeleteEncuestaCommadHandler(IEncuestaRepository encuestaRepository)
        {
            _encuestaRepository = encuestaRepository;            
        }

        public async Task<Response<int>> Handle(DeleteEncuestaCommad request, CancellationToken cancellationToken)
        {
            var encuestas = _encuestaRepository.FindById(request.Id);
            if (encuestas == null)
            {
                throw new KeyNotFoundException($"Registro no encontrado con el id {request.Id}");
            }
            else
            {
                await _encuestaRepository.Delete(encuestas);
                return new Response<int>(encuestas.IdEncuesta);
            }
        }
    }
}
