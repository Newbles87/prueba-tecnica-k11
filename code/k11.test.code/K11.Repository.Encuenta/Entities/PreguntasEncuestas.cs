using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K11.Repository.Encuenta.Entities
{
    public class PreguntasEncuestas : AuditableBaseEntity
    {
        public PreguntasEncuestas()
        {
            RespuestasEncuestas = new List<RespuestasEncuestas>();
        }
        public int IdPreguntaEncuesta { get; set; }
        public int IdEncuesta { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }
        public virtual Encuestas Encuestas { get; set; }
        public virtual List<RespuestasEncuestas> RespuestasEncuestas { get; set; }
    }
}
