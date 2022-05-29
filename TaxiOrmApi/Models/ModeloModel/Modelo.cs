using TaxiOrmApi.Models.FabricanteModel;
using TaxiOrmApi.Models.VeiculoModel;

namespace TaxiOrmApi.Models.ModeloModel
{
    public partial class Modelo : Entity
    {
        public string Nome { get; set; }
        public int FabricanteId { get; set; }
        public Fabricante Fabricante { get; set; }
        public List<Veiculo> Veiculos { get; set; }
    }
}
