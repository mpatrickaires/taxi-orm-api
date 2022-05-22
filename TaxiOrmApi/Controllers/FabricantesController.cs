using Microsoft.AspNetCore.Mvc;
using TaxiOrmApi.Models.FabricanteModel;
using TaxiOrmApi.Services.Interfaces;

namespace TaxiOrmApi.Controllers
{
    [Route("api/fabricantes")]
    [ApiController]
    public class FabricantesController : ControllerGeneric<Fabricante>
    {
        public FabricantesController(IFabricanteService service) : base(service)
        {
        }
    }
}
