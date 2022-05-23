using AutoMapper;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Models.ModeloModel;

namespace TaxiOrmApi.Mapping
{
    public class ModeloProfile : Profile
    {
        public ModeloProfile()
        {
            CreateMap<Modelo, ModeloDto>();
            CreateMap<ModeloDto, Modelo>();
        }
    }
}
