using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K11.Application.Encuenta.Features.Respuestas.Commands
{
    public class CreateRespuestaCommandValidator : AbstractValidator<CreateRespuestaCommand>
    {
        public CreateRespuestaCommandValidator()
        {
            RuleFor(p => p.UsuarioCrea)
               .NotNull().WithMessage("{PropertyName} no puede ser vacio.");               
            RuleFor(x => x.RespuestaEncuesta)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull().WithMessage("Las respuestas de la encuentas son obligatorias");
        }
    }
}
