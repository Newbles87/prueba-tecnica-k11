using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K11.Application.Encuenta.DTOs
{
    public class RespuestaEncuestaRequest
    {
        public int IdPreguntaEncuesta { get; set; }
        public string DescripcionRespuesta { get; set; }
    }
}
