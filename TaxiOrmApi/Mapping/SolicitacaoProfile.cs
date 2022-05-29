using AutoMapper;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Models.SolicitacaoModel;

namespace TaxiOrmApi.Mapping
{
    public class SolicitacaoProfile : Profile
    {
        public SolicitacaoProfile()
        {
            CreateMap<Solicitacao, SolicitacaoDto>();
            CreateMap<SolicitacaoDto, Solicitacao>();
        }
    }
}
