using AutoMapper;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Models.MotoristaModel;

namespace TaxiOrmApi.Mapping
{
    public class MotoristaProfile : Profile
    {
        public MotoristaProfile()
        {
            CreateMap<Motorista, MotoristaDto>();
            CreateMap<MotoristaDto, Motorista>();
        }
    }
}
