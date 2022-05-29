using FluentValidation;
using TaxiOrmApi.Models.Interfaces;
using TaxiOrmApi.Validator;

namespace TaxiOrmApi.Models.LocalizacaoModel
{
    public partial class Localizacao : IEntityValidator
    {
        public void Validar()
        {
            var validador = new LocalizacaoValidator();
            validador.ValidateAndThrow(this);
        }
    }

    public class LocalizacaoValidator : AbstractValidator<Localizacao>
    {
        public LocalizacaoValidator()
        {
            RuleFor(l => l.Cep)
                .FixedLength(8)
                .WithMessage(Mensagem.TamanhoMaximoNumero);

            RuleFor(l => l.Uf)
                .NotEmpty()
                .WithMessage(Mensagem.CampoObrigatorio)
                .FixedLength(2)
                .WithMessage(Mensagem.TamanhoMaximoString);

            RuleFor(l => l.Cidade)
                .NotEmpty()
                .WithMessage(Mensagem.CampoObrigatorio)
                .MaximumLength(40)
                .WithMessage(Mensagem.TamanhoMaximoString);

            RuleFor(l => l.Bairro)
                .NotEmpty()
                .WithMessage(Mensagem.CampoObrigatorio)
                .MaximumLength(40)
                .WithMessage(Mensagem.TamanhoMaximoString);

            RuleFor(l => l.Logradouro)
                .NotEmpty()
                .WithMessage(Mensagem.CampoObrigatorio)
                .MaximumLength(60)
                .WithMessage(Mensagem.TamanhoMaximoString);

            RuleFor(l => l.Numero)
                .MaximumLength(12)
                .WithMessage(Mensagem.TamanhoMaximoNumero);

            RuleFor(l => l.Complemento)
                .MaximumLength(60)
                .WithMessage(Mensagem.TamanhoMaximoString);
        }
    }
}
