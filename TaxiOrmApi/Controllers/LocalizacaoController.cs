using Microsoft.AspNetCore.Mvc;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Services.Interfaces;

namespace TaxiOrmApi.Controllers
{
    [Route("api/localizacoes")]
    [ApiController]
    public class LocalizacaoController : GenericController<LocalizacaoDto>
    {
        public LocalizacaoController(ILocalizacaoService service) : base(service)
        {
        }
    }
}
