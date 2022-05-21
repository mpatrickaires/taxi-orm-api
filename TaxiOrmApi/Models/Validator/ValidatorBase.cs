using FluentValidation;

namespace TaxiOrmApi.Models.Validator
{
    public class ValidatorBase<TEntity> : AbstractValidator<TEntity>
    {
        public ValidatorBase()
        {
        }
    }
}
