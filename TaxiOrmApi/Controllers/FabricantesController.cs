using Microsoft.AspNetCore.Mvc;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Services.Interfaces;

namespace TaxiOrmApi.Controllers
{
    [Route("api/fabricantes")]
    [ApiController]
    public class FabricantesController : GenericController<FabricanteDto>
    {
        public FabricantesController(IFabricanteService service) : base(service)
        {
        }
    }
}
