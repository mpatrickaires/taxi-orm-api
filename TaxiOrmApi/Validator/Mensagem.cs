namespace TaxiOrmApi.Validator
{
    public static class Mensagem
    {
        private static string Campo => "O campo {PropertyName}";
        private static string TamanhoMaximo => $"{Campo} não pode exceder {{MaxLength}}";

        public static string CampoObrigatorio => $"{Campo} é obrigatório";
        public static string TamanhoMaximoString => $"{TamanhoMaximo} caracteres";
        public static string TamanhoMaximoNumero => $"{TamanhoMaximo} números";

        public static string TamanhoFixoNumero => $"{TamanhoMaximo} números";
    }
}
