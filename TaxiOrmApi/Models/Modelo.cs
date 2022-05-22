using FluentValidation;
using TaxiOrmApi.Models.Validator;

namespace TaxiOrmApi.Models
{
    public class Modelo : Entity
    {
        public string Nome { get; set; }
        public int FabricanteId { get; set; }
        public Fabricante Fabricante { get; set; }
    }

    public class ModeloValidator : ValidatorBase<Modelo>
    {
        public ModeloValidator()
        {
            RuleFor(m => m.Nome)
                .NotEmpty().WithMessage(Mensagem.CampoObrigatorio)
                .MaximumLength(80).WithMessage(Mensagem.TamanhoMaximoString);
        }
    }
}
