using AutoMapper;
using K11.Application.Encuenta.DTOs;
using K11.Application.Encuenta.Features.Encuentas.Commands;
using K11.Repository.Encuenta.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K11.Application.Encuenta.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            #region Commands
            CreateMap<CreateEncuestaCommad, Encuestas>();
            CreateMap<PreguntasEncuestaRequest, PreguntasEncuestas>();
            CreateMap<PreguntasEncuestaDto, PreguntasEncuestas>();
            CreateMap<RespuestaEncuestaRequest, RespuestasEncuestas>();
            #endregion
            #region DTOs
            CreateMap<Encuestas, EncuestaDto>();
            CreateMap<PreguntasEncuestas, PreguntasEncuestaDto>();
            CreateMap<EstadisticaRespuesta, EstadisticaRespuestaDto>().ReverseMap();
            #endregion
        }
    }
}
