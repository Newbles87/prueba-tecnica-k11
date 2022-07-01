using K11.Repository.Encuenta.Context;
using K11.Repository.Encuenta.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K11.Repository.Encuenta.Persistence
{
    public class RespuestasEncuestaRepository: IRespuestasEncuestaRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public RespuestasEncuestaRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<bool> Add(List<RespuestasEncuestas> respuestas, int usuarioCrea)
        {
            var rsp = new List<RespuestasEncuestas>();
            bool transc = false;
            foreach (var r in respuestas)
            {
                var pregunta = _applicationDbContext.PreguntasEncuestas.FirstOrDefault(x => x.IdPreguntaEncuesta == r.IdPreguntaEncuesta);
                if (pregunta != null)
                {
                    r.UsuarioCrea = usuarioCrea;
                    r.Estado = 1;
                    r.FechaCrea = DateTime.Now;
                    rsp.Add(r);
                }                
            }
            if (rsp.Any())
            {
                await _applicationDbContext.RespuestasEncuestas.AddRangeAsync(rsp);
                await _applicationDbContext.SaveChangesAsync();
                transc = true;
                return transc;
            }           
            return transc;
        }

        public bool Exits(int id)
        {
            var validate = from r in _applicationDbContext.RespuestasEncuestas
                           join p in _applicationDbContext.PreguntasEncuestas on r.IdPreguntaEncuesta equals p.IdPreguntaEncuesta
                           where p.IdEncuesta == id
                           select r;
            return validate.Any();
        }

        public List<EstadisticaRespuesta> Stadistic()
        {
            var queryable = from r in _applicationDbContext.RespuestasEncuestas
                           join p in _applicationDbContext.PreguntasEncuestas on r.IdPreguntaEncuesta equals p.IdPreguntaEncuesta
                           select new EstadisticaRespuesta 
                           {
                               
                               IdPreguntaEncuesta = r.IdPreguntaEncuesta,
                               Descripcion = p.Descripcion
                           };


            var result = from x in queryable
                         group x by new {x.IdPreguntaEncuesta, x.Descripcion} into g
                         select new EstadisticaRespuesta
                         {
                              IdPreguntaEncuesta = g.Key.IdPreguntaEncuesta,
                              Descripcion = g.Key.Descripcion,
                              Cantidad = g.Count()
                          };

            return result.ToList();
        }

    }
}
