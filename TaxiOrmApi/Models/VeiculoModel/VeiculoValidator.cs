using FluentValidation;
using TaxiOrmApi.Models.Interfaces;
using TaxiOrmApi.Validator;

namespace TaxiOrmApi.Models.VeiculoModel
{
    public partial class Veiculo : IEntityValidator
    {
        public void Validar()
        {
            var validador = new VeiculoValidator();
            validador.ValidateAndThrow(this);
        }
    }

    public class VeiculoValidator : AbstractValidator<Veiculo>
    {
        public VeiculoValidator()
        {
            RuleFor(v => v.ModeloId)
                .NotEmpty()
                .WithMessage(Mensagem.CampoObrigatorio);

            RuleFor(v => v.Renavam)
                .NotEmpty()
                .WithMessage(Mensagem.CampoObrigatorio)
                .FixedLength(11)
                .WithMessage(Mensagem.TamanhoFixoNumero);

            RuleFor(v => v.Ano)
                .NotEmpty()
                .WithMessage(Mensagem.CampoObrigatorio);
        }
    }
}
