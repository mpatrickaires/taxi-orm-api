using FluentValidation;
using TaxiOrmApi.Models.Interfaces;
using TaxiOrmApi.Validator;

namespace TaxiOrmApi.Models.ModeloModel
{
    public partial class Modelo : IEntityValidator
    {
        public void Validar()
        {
            var validador = new ModeloValidator();
            validador.ValidateAndThrow(this);
        }
    }

    public class ModeloValidator : AbstractValidator<Modelo>
    {
        public ModeloValidator()
        {
            RuleFor(m => m.Nome)
            .NotEmpty().WithMessage(Mensagem.CampoObrigatorio)
            .MaximumLength(80).WithMessage(Mensagem.TamanhoMaximoString);

            RuleFor(m => m.FabricanteId)
                .NotEmpty().WithMessage(Mensagem.CampoObrigatorio);
        }
    }
}
