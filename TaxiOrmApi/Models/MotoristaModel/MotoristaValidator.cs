using FluentValidation;
using TaxiOrmApi.Models.Interfaces;
using TaxiOrmApi.Validator;

namespace TaxiOrmApi.Models.MotoristaModel
{
    public partial class Motorista : IEntityValidator
    {
        public void Validar()
        {
            var validador = new MotoristaValidator();
            validador.ValidateAndThrow(this);
        }
    }

    public class MotoristaValidator : AbstractValidator<Motorista>
    {
        public MotoristaValidator()
        {
            RuleFor(m => m.Nome)
                .NotEmpty()
                .WithMessage(Mensagem.CampoObrigatorio)
                .MaximumLength(60)
                .WithMessage(Mensagem.TamanhoMaximoString);

            RuleFor(m => m.Cpf)
                .NotEmpty()
                .WithMessage(Mensagem.CampoObrigatorio)
                .FixedLength(11)
                .WithMessage(Mensagem.TamanhoFixoNumero);

            RuleFor(m => m.NumeroCnh)
                .NotEmpty()
                .WithMessage(Mensagem.CampoObrigatorio)
                .FixedLength(11)
                .WithMessage(Mensagem.TamanhoFixoNumero);
        }
    }
}
