using FluentValidation;
using TaxiOrmApi.Models.Interfaces;
using TaxiOrmApi.Models.Validator;

namespace TaxiOrmApi.Models.FabricanteModel
{
    public partial class Fabricante : IEntityValidator
    {
        public void Validar()
        {
            var validador = new FabricanteValidator();
            validador.ValidateAndThrow(this);
        }

        public class FabricanteValidator : AbstractValidator<Fabricante>
        {
            public FabricanteValidator()
            {
                RuleFor(f => f.Nome)
                .NotEmpty().WithMessage(Mensagem.CampoObrigatorio)
                .MaximumLength(80).WithMessage(Mensagem.TamanhoMaximoString);
            }
        }
    }
}
