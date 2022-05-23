using FluentValidation;

namespace TaxiOrmApi.Validator
{
    public static class AbstractValidatorExtension
    {
        public static IRuleBuilderOptions<T, string> FixedLength<T>(this IRuleBuilderOptions<T, string> abstractValidator, int length)
        {
            abstractValidator.Length(length, length);
            return abstractValidator;
        }
    }
}
