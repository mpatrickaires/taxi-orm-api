using AutoMapper;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Models.VeiculoModel;

namespace TaxiOrmApi.Mapping
{
    public class VeiculoProfile : Profile
    {
        public VeiculoProfile()
        {
            CreateMap<Veiculo, VeiculoDto>();
            CreateMap<VeiculoDto, Veiculo>();
        }
    }
}
