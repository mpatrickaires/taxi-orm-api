using Microsoft.AspNetCore.Mvc;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Services.Interfaces;

namespace TaxiOrmApi.Controllers
{
    [Route("api/modelos")]
    [ApiController]
    public class ModeloController : GenericController<ModeloDto>
    {
        public ModeloController(IModeloService service) : base(service)
        {
        }
    }
}
