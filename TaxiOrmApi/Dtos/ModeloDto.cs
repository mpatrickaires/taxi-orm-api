using TaxiOrmApi.Models.FabricanteModel;

namespace TaxiOrmApi.Dtos
{
    public class ModeloDto : EntityDto
    {
        public string Nome { get; set; }
        public int FabricanteId { get; set; }
        public Fabricante Fabricante { get; set; }
        public List<VeiculoDto> Veiculos { get; set; }
    }
}
