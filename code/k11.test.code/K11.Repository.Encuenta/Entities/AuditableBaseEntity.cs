using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K11.Repository.Encuenta.Entities
{
    public abstract class AuditableBaseEntity
    {
        public int UsuarioCrea { get; set; }
        public DateTime FechaCrea { get; set; }
        public int UsuarioModifica { get; set; }
        public DateTime? FechaModifica { get; set; }
    }
}
