using Microsoft.AspNetCore.Mvc;
using TaxiOrmApi.Models;
using TaxiOrmApi.Services.Interfaces;

namespace TaxiOrmApi.Controllers
{
    [Route("api/modelos")]
    [ApiController]
    public class ModeloController : ControllerGeneric<Modelo>
    {
        public ModeloController(IModeloService service) : base(service)
        {
        }
    }
}
