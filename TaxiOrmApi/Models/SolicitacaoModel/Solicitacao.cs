using TaxiOrmApi.Models.ClienteModel;
using TaxiOrmApi.Models.LocalizacaoModel;
using TaxiOrmApi.Models.MotoristaModel;

namespace TaxiOrmApi.Models.SolicitacaoModel
{
    public partial class Solicitacao : Entity
    {
        public DateTime DataHora { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int MotoristaId { get; set; }
        public Motorista Motorista { get; set; }
        public int LocalizacaoOrigemId { get; set; }
        public Localizacao LocalizacaoOrigem { get; set; }
        public int LocalizacaoDestinoId { get; set; }
        public Localizacao LocalizacaoDestino { get; set; }
    }
}
