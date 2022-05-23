using AutoMapper;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Models.FabricanteModel;

namespace TaxiOrmApi.Mapping
{
    public class FabricanteProfile : Profile
    {
        public FabricanteProfile()
        {
            CreateMap<Fabricante, FabricanteDto>();
            CreateMap<FabricanteDto, Fabricante>();
        }
    }
}
