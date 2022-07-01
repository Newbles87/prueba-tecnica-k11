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
    public class PreguntasEncuestaConfig : IEntityTypeConfiguration<PreguntasEncuestas>
    {
        public void Configure(EntityTypeBuilder<PreguntasEncuestas> builder)
        {
            builder.ToTable("PreguntasEncuestas", "trsobj");
            builder.HasKey(p => p.IdPreguntaEncuesta);
            builder.Property(p => p.IdEncuesta);
            builder.Property(p => p.Descripcion)
                .HasMaxLength(250);
            builder.Property(p => p.Estado);
            builder.Property(p => p.UsuarioCrea);
            builder.Property(p => p.FechaCrea);
            builder.Property(p => p.UsuarioModifica);
            builder.Property(p => p.FechaModifica);
            builder.HasOne(d => d.Encuestas)
                    .WithMany(p => p.PreguntasEncuestas)
                    .HasForeignKey(d => d.IdEncuesta)
                    .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
