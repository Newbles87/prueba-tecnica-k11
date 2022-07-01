using K11.Repository.Encuenta.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K11.Repository.Encuenta.Persistence
{
    public interface IEncuestaRepository
    {
        Task<Encuestas> Add(Encuestas Encuestas);
        Task<int> Delete(Encuestas Encuestas);
        Encuestas FindById(int id);
        Task<int> Update(Encuestas Encuestas, List<PreguntasEncuestas> preguntas);
    }
}
