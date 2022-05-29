using FluentValidation;
using TaxiOrmApi.Models.Interfaces;
using TaxiOrmApi.Validator;

namespace TaxiOrmApi.Models.ClienteModel
{
    public partial class Cliente : IEntityValidator
    {
        public void Validar()
        {
            var validador = new ClienteValidator();
            validador.ValidateAndThrow(this);
        }
    }

    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(c => c.Nome)
                .NotEmpty()
                .WithMessage(Mensagem.CampoObrigatorio)
                .MaximumLength(60)
                .WithMessage(Mensagem.TamanhoMaximoString);

            RuleFor(c => c.Cpf)
                .NotEmpty()
                .WithMessage(Mensagem.CampoObrigatorio)
                .FixedLength(11)
                .WithMessage(Mensagem.TamanhoFixoNumero);

            RuleFor(c => c.DataCadastro)
                .NotEmpty()
                .WithMessage(Mensagem.CampoObrigatorio);
        }
    }
}
