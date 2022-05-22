using TaxiOrmApi.Models.ModeloModel;

namespace TaxiOrmApi.Models.FabricanteModel
{
    public partial class Fabricante : Entity
    {
        public string Nome { get; set; }
        public List<Modelo> Modelos { get; set; }
    }
}
