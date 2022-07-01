using K11.Repository.Encuenta.Context;
using K11.Repository.Encuenta.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K11.Repository.Encuenta.Persistence
{
    public class EncuestaRepository: IEncuestaRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public EncuestaRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<Encuestas> Add(Encuestas encuestas)
        {
            encuestas.Estado = 1;
            encuestas.FechaCrea = DateTime.Now;
            foreach (var preguntas in encuestas.PreguntasEncuestas)
            {
                preguntas.UsuarioCrea = encuestas.UsuarioCrea;
                preguntas.FechaCrea = DateTime.Now;
                preguntas.Estado = 1;                
            }
            _applicationDbContext.Encuestas.Add(encuestas);
            await _applicationDbContext.SaveChangesAsync();           
            return encuestas;
        }

        public async Task<int> Delete(Encuestas encuestas)
        {
            _applicationDbContext.PreguntasEncuestas.RemoveRange(encuestas.PreguntasEncuestas);
            _applicationDbContext.Encuestas.Remove(encuestas);
            return await _applicationDbContext.SaveChangesAsync();
        }

        public Encuestas FindById(int id)
        {
            var encuesta = _applicationDbContext.Encuestas.FirstOrDefault(x => x.IdEncuesta == id);
            if (encuesta != null)
            {
                encuesta.PreguntasEncuestas = _applicationDbContext.PreguntasEncuestas.Where(x => x.IdEncuesta==id).ToList();
            }
            return encuesta;
        }

        public async Task<int> Update(Encuestas encuestas, List<PreguntasEncuestas> preguntas)
        {
            encuestas.FechaModifica = DateTime.Now;            
            _applicationDbContext.Encuestas.Update(encuestas);
            var UpdateEncuesta = await _applicationDbContext.SaveChangesAsync();
            foreach (var p in preguntas)
            {
                var pregunta = _applicationDbContext.PreguntasEncuestas.FirstOrDefault(x => x.IdPreguntaEncuesta == p.IdPreguntaEncuesta);
                if (pregunta != null)
                {
                    pregunta.Descripcion = p.Descripcion;
                    pregunta.UsuarioModifica = encuestas.UsuarioModifica;
                    pregunta.FechaModifica = DateTime.Now;
                    _applicationDbContext.PreguntasEncuestas.Update(pregunta);
                    var UpdatePreguntaEncuesta = await _applicationDbContext.SaveChangesAsync();
                }
            }
            return UpdateEncuesta;
        }
    }
}
