using TaxiOrmApi.Models.TelefoneClienteModel;

namespace TaxiOrmApi.Models.ClienteModel
{
    public partial class Cliente : Entity
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<TelefoneCliente> Telefones { get; set; }
    }
}
