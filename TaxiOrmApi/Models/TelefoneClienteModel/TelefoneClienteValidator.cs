using FluentValidation;
using TaxiOrmApi.Models.Interfaces;
using TaxiOrmApi.Validator;

namespace TaxiOrmApi.Models.TelefoneClienteModel
{
    public partial class TelefoneCliente : IEntityValidator
    {
        public void Validar()
        {
            var validador = new TelefoneClienteValidator();
            validador.ValidateAndThrow(this);
        }
    }

    public class TelefoneClienteValidator : AbstractValidator<TelefoneCliente>
    {
        public TelefoneClienteValidator()
        {
            RuleFor(t => t.ClienteId)
                .NotEmpty()
                .WithMessage(Mensagem.CampoObrigatorio);

            RuleFor(t => t.Numero)
                .NotEmpty()
                .WithMessage(Mensagem.CampoObrigatorio)
                .MaximumLength(15)
                .WithMessage(Mensagem.TamanhoMaximoNumero);
        }
    }
}
