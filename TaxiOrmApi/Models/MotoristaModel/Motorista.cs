using TaxiOrmApi.Models.VeiculoModel;

namespace TaxiOrmApi.Models.MotoristaModel
{
    public partial class Motorista : Entity
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string NumeroCnh { get; set; }
        public int? VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }
    }
}
