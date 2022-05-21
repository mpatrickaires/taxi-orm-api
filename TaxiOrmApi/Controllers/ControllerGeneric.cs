using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using TaxiOrmApi.Models;
using TaxiOrmApi.Services.Interfaces;

namespace TaxiOrmApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControllerGeneric<TEntity> : ControllerBase where TEntity : Entity
    {
        private IServiceBase<TEntity> _service;

        protected ControllerGeneric(IServiceBase<TEntity> service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var entities = _service.ObterTodos();

            if (entities == null || !entities.Any()) return RegistroNaoEncontrado();

            return Ok(entities);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var entity = _service.ObterPorId(id);

            if (entity == null) return RegistroNaoEncontrado();

            return Ok(_service.ObterPorId(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] TEntity entity)
        {
            if (_service.ObterPorId(entity.Id) != null) return RegistroJaCadastrado();

            try
            {
                _service.Inserir(entity);
                return CreatedAtAction(nameof(Post), new { id = entity.Id }, entity);
            }
            catch (ValidationException e)
            {
                return BadRequest(e.Errors);
                throw;
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] TEntity entity)
        {
            entity.Id = id;

            try
            {
                if (_service.ObterPorId(id) != null)
                {
                    _service.Atualizar(entity);
                    return NoContent();
                }

                _service.Inserir(entity);
                return CreatedAtAction(nameof(Put), new { id = entity.Id }, entity);
            }
            catch (ValidationException e)
            {
                return BadRequest(e.Errors);
                throw;
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var entity = _service.ObterPorId(id);

            if (entity == null) return RegistroNaoEncontrado();

            _service.Deletar(entity);
            return NoContent();
        }

        protected ContentResult RegistroNaoEncontrado(string message = "Registro não encontrado.")
        {
            var response = Content(message);
            response.StatusCode = StatusCodes.Status404NotFound;
            return response;
        }

        protected ContentResult RegistroJaCadastrado(string message = "Registro já cadastrado.")
        {
            var response = Content(message);
            response.StatusCode = StatusCodes.Status409Conflict;
            return response;
        }
    }
}
