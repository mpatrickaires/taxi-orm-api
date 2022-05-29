using FluentValidation;
using TaxiOrmApi.Models.Interfaces;
using TaxiOrmApi.Validator;

namespace TaxiOrmApi.Models.SolicitacaoModel
{
    public partial class Solicitacao : IEntityValidator
    {
        public void Validar()
        {
            var validador = new SolicitacaoValidator();
            validador.ValidateAndThrow(this);
        }
    }

    public class SolicitacaoValidator : AbstractValidator<Solicitacao>
    {
        public SolicitacaoValidator()
        {
            RuleFor(s => s.DataHora)
                .NotEmpty()
                .WithMessage(Mensagem.CampoObrigatorio);

            RuleFor(s => s.ClienteId)
                .NotEmpty()
                .WithMessage(Mensagem.CampoObrigatorio);

            RuleFor(s => s.MotoristaId)
                .NotEmpty()
                .WithMessage(Mensagem.CampoObrigatorio);

            RuleFor(s => s.LocalizacaoOrigemId)
                .NotEmpty()
                .WithMessage(Mensagem.CampoObrigatorio);

            RuleFor(s => s.LocalizacaoDestinoId)
                .NotEmpty()
                .WithMessage(Mensagem.CampoObrigatorio);
        }
    }
}
