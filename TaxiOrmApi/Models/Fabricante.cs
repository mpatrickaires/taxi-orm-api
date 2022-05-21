using FluentValidation;
using TaxiOrmApi.Models.Validator;

namespace TaxiOrmApi.Models
{
    public class Fabricante : Entity
    {
        public string Nome { get; set; }
    }

    public class FabricanteValidator : ValidatorBase<Fabricante>
    {
        public FabricanteValidator()
        {
            RuleFor(f => f.Nome)
                .NotEmpty().WithMessage(Mensagem.CampoObrigatorio)
                .MaximumLength(80).WithMessage(Mensagem.TamanhoMaximoString);
        }
    }
}
