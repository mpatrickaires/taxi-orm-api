namespace TaxiOrmApi.Dtos
{
    public class SolicitacaoDto : EntityDto
    {
        public DateTime DataHora { get; set; }
        public int ClienteId { get; set; }
        public ClienteDto Cliente { get; set; }
        public int MotoristaId { get; set; }
        public MotoristaDto Motorista { get; set; }
        public int LocalizacaoOrigemId { get; set; }
        public LocalizacaoDto LocalizacaoOrigem { get; set; }
        public int LocalizacaoDestinoId { get; set; }
        public LocalizacaoDto LocalizacaoDestino { get; set; }
    }
}
