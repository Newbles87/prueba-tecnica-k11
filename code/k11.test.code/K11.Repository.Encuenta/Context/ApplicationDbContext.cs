using K11.Repository.Encuenta.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace K11.Repository.Encuenta.Context
{
    public class ApplicationDbContext : DbContext
    {        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {            
        }
        public DbSet<Encuestas> Encuestas { get; set; }
        public DbSet<PreguntasEncuestas> PreguntasEncuestas { get; set; }
        public DbSet<RespuestasEncuestas> RespuestasEncuestas { get; set; }

        //va crearse el 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
