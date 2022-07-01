using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K11.Repository.Encuenta.Entities
{
    public class Encuestas: AuditableBaseEntity
    {
        public Encuestas()
        {
            PreguntasEncuestas = new List<PreguntasEncuestas>();
        }
        public int IdEncuesta { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }
        public virtual List<PreguntasEncuestas> PreguntasEncuestas { get; set; }
    }
}
