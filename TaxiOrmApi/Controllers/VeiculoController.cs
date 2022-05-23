using Microsoft.AspNetCore.Mvc;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Services.Interfaces;

namespace TaxiOrmApi.Controllers
{
    [Route("api/veiculos")]
    [ApiController]
    public class VeiculoController : GenericController<VeiculoDto>
    {
        public VeiculoController(IVeiculoService service) : base(service)
        {
        }
    }
}
