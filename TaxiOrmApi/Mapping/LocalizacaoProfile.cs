using AutoMapper;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Models.LocalizacaoModel;

namespace TaxiOrmApi.Mapping
{
    public class LocalizacaoProfile : Profile
    {
        public LocalizacaoProfile()
        {
            CreateMap<Localizacao, LocalizacaoDto>();
            CreateMap<LocalizacaoDto, Localizacao>();
        }
    }
}
