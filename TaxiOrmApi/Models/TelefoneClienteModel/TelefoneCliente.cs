using TaxiOrmApi.Models.ClienteModel;

namespace TaxiOrmApi.Models.TelefoneClienteModel
{
    public partial class TelefoneCliente : Entity
    {
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public string Numero { get; set; }
    }
}
