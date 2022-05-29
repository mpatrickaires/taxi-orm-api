using AutoMapper;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Models.SolicitacaoModel;
using TaxiOrmApi.Repositories.Interfaces;
using TaxiOrmApi.Services.Interfaces;

namespace TaxiOrmApi.Services
{
    public class SolicitacaoService : GenericService<Solicitacao, SolicitacaoDto>, ISolicitacaoService
    {
        public SolicitacaoService(ISolicitacaoRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
