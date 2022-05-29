namespace TaxiOrmApi.Dtos
{
    public class LocalizacaoDto : EntityDto
    {
        public string Cep { get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public List<SolicitacaoDto> SolicitacoesOrigem { get; set; }
        public List<SolicitacaoDto> SolicitacoesDestino { get; set; }
    }
}
