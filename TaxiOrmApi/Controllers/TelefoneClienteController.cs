using Microsoft.AspNetCore.Mvc;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Services.Interfaces;

namespace TaxiOrmApi.Controllers
{
    [Route("api/telefone-clientes")]
    [ApiController]
    public class TelefoneClienteController : GenericController<TelefoneClienteDto>
    {
        public TelefoneClienteController(ITelefoneClienteService service) : base(service)
        {
        }
    }
}
