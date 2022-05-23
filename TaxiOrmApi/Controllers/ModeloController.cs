using Microsoft.AspNetCore.Mvc;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Models.ModeloModel;
using TaxiOrmApi.Services.Interfaces;

namespace TaxiOrmApi.Controllers
{
    [Route("api/modelos")]
    [ApiController]
    public class ModeloController : ControllerGeneric<Modelo, ModeloDto>
    {
        public ModeloController(IModeloService service) : base(service)
        {
        }
    }
}
