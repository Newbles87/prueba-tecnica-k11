using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K11.Repository.Encuenta.Entities
{
    public class RespuestasEncuestas : AuditableBaseEntity
    {
        public int IdRespuestaEncuenta { get; set; }
        public int IdPreguntaEncuesta { get; set; }
        public string DescripcionRespuesta { get; set; }
        public int Estado { get; set; }
        public virtual PreguntasEncuestas PreguntasEncuestas { get; set; }
    }
}
