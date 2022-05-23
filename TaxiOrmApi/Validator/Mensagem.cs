namespace TaxiOrmApi.Validator
{
    public static class Mensagem
    {
        public static string CampoObrigatorio => "O campo {PropertyName} é obrigatório";
        public static string TamanhoMaximoString => "O campo {PropertyName} não pode exceder {MaxLength} caracteres";

        public static string TamanhoFixoNumero => "O campo {PropertyName} deve possuir um tamanho fixo de {MaxLength} números";
    }
}
