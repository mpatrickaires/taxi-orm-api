using TaxiOrmApi.Models.ClienteModel;

namespace TaxiOrmApi.Dtos
{
    public class TelefoneClienteDto : EntityDto
    {
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public string Numero { get; set; }
    }
}
