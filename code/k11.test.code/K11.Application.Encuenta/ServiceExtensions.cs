using FluentValidation;
using K11.Application.Encuenta.Behaviors;
using K11.Repository.Encuenta.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace K11.Application.Encuenta
{
    public static class ServiceExtensions
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            
            services.AddAutoMapper(Assembly.GetExecutingAssembly());            
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());            
            services.AddMediatR(Assembly.GetExecutingAssembly());            
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            services.AddScoped<IEncuestaRepository, EncuestaRepository>();
            services.AddScoped<IRespuestasEncuestaRepository, RespuestasEncuestaRepository>();
        }
    }
}
