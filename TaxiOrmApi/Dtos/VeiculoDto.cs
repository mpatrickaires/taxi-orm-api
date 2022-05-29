using TaxiOrmApi.Models.ModeloModel;

namespace TaxiOrmApi.Dtos
{
    public class VeiculoDto : EntityDto
    {
        public int ModeloId { get; set; }
        public Modelo Modelo { get; set; }
        public string Renavam { get; set; }
        public int Ano { get; set; }
        public MotoristaDto Motorista { get; set; }
    }
}
