using AutoMapper;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Models.LocalizacaoModel;
using TaxiOrmApi.Repositories.Interfaces;
using TaxiOrmApi.Services.Interfaces;

namespace TaxiOrmApi.Services
{
    public class LocalizacaoService : GenericService<Localizacao, LocalizacaoDto>, ILocalizacaoService
    {
        public LocalizacaoService(ILocalizacaoRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
