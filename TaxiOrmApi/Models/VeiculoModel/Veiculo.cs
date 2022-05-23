using TaxiOrmApi.Models.ModeloModel;
using TaxiOrmApi.Models.MotoristaModel;

namespace TaxiOrmApi.Models.VeiculoModel
{
    public partial class Veiculo : Entity
    {
        public int ModeloId { get; set; }
        public Modelo Modelo { get; set; }
        public string Renavam { get; set; }
        public int Ano { get; set; }
        public Motorista Motorista { get; set; }
    }
}
