using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K11.Repository.Encuenta.Entities
{
    public class EstadisticaRespuesta
    {
        public int IdPreguntaEncuesta { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
    }
}
