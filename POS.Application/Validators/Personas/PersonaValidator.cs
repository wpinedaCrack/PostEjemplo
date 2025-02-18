using FluentValidation;
using POS.Application.Dtos.Request;
using POST.Domain.Entities;

namespace POS.Application.Validators.Personas
{
    public class PersonaValidator : AbstractValidator<PersonaRequestDto>
    {
        public PersonaValidator()
        {
            RuleFor(x => x.Nombre)
              .NotNull().WithMessage("El campo 'Nombre' no puede ser nulo.")
              .NotEmpty().WithMessage("El campo 'Nombre' no puede estar vacío.");

            RuleFor(x => x.Apellido)
             .NotNull().WithMessage("El campo 'Apellido' no puede ser nulo.")
             .NotEmpty().WithMessage("El campo 'Apellido' no puede estar vacío.");
        }
    }
}
