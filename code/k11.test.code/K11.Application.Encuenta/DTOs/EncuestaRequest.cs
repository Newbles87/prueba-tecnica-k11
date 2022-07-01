using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K11.Application.Encuenta.DTOs
{
    public class EncuestaRequest
    {        
        public string Descripcion { get; set; }
        public int UsuarioModifica { get; set; }
        public List<PreguntasEncuestaDto> PreguntasEncuestas { get; set; }
    }
}
