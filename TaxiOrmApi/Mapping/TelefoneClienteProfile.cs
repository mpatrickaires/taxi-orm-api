using AutoMapper;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Models.TelefoneClienteModel;

namespace TaxiOrmApi.Mapping
{
    public class TelefoneClienteProfile : Profile
    {
        public TelefoneClienteProfile()
        {
            CreateMap<TelefoneCliente, TelefoneClienteDto>();
            CreateMap<TelefoneClienteDto, TelefoneCliente>();
        }
    }
}
