using FluentValidation;

namespace TaxiOrmApi.Validator
{
    public static class AbstractValidatorExtension
    {
        public static IRuleBuilderOptions<T, string> FixedLength<T>(this IRuleBuilderOptions<T, string> abstractValidator, int length)
        {
            return abstractValidator.Length(length, length);
        }

        public static IRuleBuilderOptions<T, string> FixedLength<T>(this IRuleBuilderInitial<T, string> abstractValidator, int length)
        {
            return abstractValidator.Length(length, length);
        }
    }
}
