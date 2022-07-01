using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K11.Application.Encuenta.Features.Encuentas.Commands
{
    public class CreateEncuestaCommadValidator: AbstractValidator<CreateEncuestaCommad>
    {
        public CreateEncuestaCommadValidator()
        {
            RuleFor(p => p.Descripcion)
               .NotEmpty().WithMessage("{PropertyName} no puede ser vacio.")
               .MaximumLength(250).WithMessage("{PropertyName} no debe exceder de {MaxLength} caracteres");
            RuleFor(x => x.PreguntasEncuestas)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull().WithMessage("Las preguntas de la encuentas son obligatorias");            
                
        }
    }
}
