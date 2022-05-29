namespace TaxiOrmApi.Dtos
{
    public class ClienteDto : EntityDto
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<TelefoneClienteDto> Telefones { get; set; }
        public List<SolicitacaoDto> Solicitacoes { get; set; }
    }
}
