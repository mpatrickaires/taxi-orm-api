using Microsoft.AspNetCore.Mvc;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Services.Interfaces;

namespace TaxiOrmApi.Controllers
{
    [Route("api/clientes")]
    [ApiController]
    public class ClienteController : GenericController<ClienteDto>
    {
        public ClienteController(IClienteService service) : base(service)
        {
        }
    }
}
