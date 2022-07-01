﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K11.Application.Encuenta.Features.Encuentas.Commands
{
    public class DeleteEncuestaCommadValidator: AbstractValidator<DeleteEncuestaCommad>
    {
        public DeleteEncuestaCommadValidator()
        {
            RuleFor(x => x.Id)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull().WithMessage("El Id es necesario para realizar la operacion")
                .NotEqual(0).WithMessage("No puede enviar un valor igual a cero");
        }
    }
}
