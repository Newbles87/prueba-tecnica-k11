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
    public class EncuestaConfig : IEntityTypeConfiguration<Encuestas>
    {
        public void Configure(EntityTypeBuilder<Encuestas> builder)
        {
            builder.ToTable("Encuestas", "trsobj");
            builder.HasKey(p => p.IdEncuesta);
            builder.Property(p => p.Descripcion)
                .HasMaxLength(250);                
            builder.Property(p => p.Estado);
            builder.Property(p => p.UsuarioCrea);
            builder.Property(p => p.FechaCrea);
            builder.Property(p => p.UsuarioModifica);
            builder.Property(p => p.FechaModifica);
        }
    }
}
