using TaxiOrmApi.Models.SolicitacaoModel;

namespace TaxiOrmApi.Models.LocalizacaoModel
{
    public partial class Localizacao : Entity
    {
        public string Cep { get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public List<Solicitacao> SolicitacoesOrigem { get; set; }
        public List<Solicitacao> SolicitacoesDestino { get; set; }
    }
}
