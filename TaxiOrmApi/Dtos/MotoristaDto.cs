using TaxiOrmApi.Models.VeiculoModel;

namespace TaxiOrmApi.Dtos
{
    public class MotoristaDto : EntityDto
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string NumeroCnh { get; set; }
        public int? VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }
        public List<SolicitacaoDto> Solicitacoes { get; set; }
    }
}
