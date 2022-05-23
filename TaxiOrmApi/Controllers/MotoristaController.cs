using Microsoft.AspNetCore.Mvc;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Services.Interfaces;

namespace TaxiOrmApi.Controllers
{
    [Route("api/motoristas")]
    [ApiController]
    public class MotoristaController : GenericController<MotoristaDto>
    {
        public MotoristaController(IMotoristaService service) : base(service)
        {
        }
    }
}
