using AutoMapper;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Models.ClienteModel;

namespace TaxiOrmApi.Mapping
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<Cliente, ClienteDto>();
            CreateMap<ClienteDto, Cliente>();
        }
    }
}
