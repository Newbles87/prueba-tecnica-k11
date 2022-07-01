using K11.Repository.Encuenta.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K11.Repository.Encuenta.Configuration
{
    public class RespuestasEncuestaConfig : IEntityTypeConfiguration<RespuestasEncuestas>
    {
        public void Configure(EntityTypeBuilder<RespuestasEncuestas> builder)
        {
            builder.ToTable("RespuestasEncuestas", "trsobj");
            builder.HasKey(p => p.IdRespuestaEncuenta);
            builder.Property(p => p.IdPreguntaEncuesta);
            builder.Property(p => p.DescripcionRespuesta)
                .HasMaxLength(250);
            builder.Property(p => p.Estado);
            builder.Property(p => p.UsuarioCrea);
            builder.Property(p => p.FechaCrea);
            builder.Property(p => p.UsuarioModifica);
            builder.Property(p => p.FechaModifica);
            builder.HasOne(d => d.PreguntasEncuestas)
                    .WithMany(p => p.RespuestasEncuestas)
                    .HasForeignKey(d => d.IdPreguntaEncuesta)
                    .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
