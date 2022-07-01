using K11.Repository.Encuenta.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K11.Repository.Encuenta.Persistence
{
    public interface IRespuestasEncuestaRepository
    {
        Task<bool> Add(List<RespuestasEncuestas> respuestas, int usuarioCrea);
        bool Exits(int id);
        List<EstadisticaRespuesta> Stadistic();
    }
}
