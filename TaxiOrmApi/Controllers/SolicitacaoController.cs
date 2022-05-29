using Microsoft.AspNetCore.Mvc;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Services.Interfaces;

namespace TaxiOrmApi.Controllers
{
    [Route("api/solicitacoes")]
    [ApiController]
    public class SolicitacaoController : GenericController<SolicitacaoDto>
    {
        public SolicitacaoController(ISolicitacaoService service) : base(service)
        {
        }
    }
}
