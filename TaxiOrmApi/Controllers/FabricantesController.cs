using Microsoft.AspNetCore.Mvc;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Models.FabricanteModel;
using TaxiOrmApi.Services.Interfaces;

namespace TaxiOrmApi.Controllers
{
    [Route("api/fabricantes")]
    [ApiController]
    public class FabricantesController : ControllerGeneric<Fabricante, FabricanteDto>
    {
        public FabricantesController(IFabricanteService service) : base(service)
        {
        }
    }
}
