using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using TaxiOrmApi.Controllers.CustomResponses;
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

            if (entities == null || !entities.Any()) return CustomResponse.RegistroNaoEncontrado();

            return Ok(entities);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var entity = _service.ObterPorId(id);

            if (entity == null) return CustomResponse.RegistroNaoEncontrado();

            return Ok(_service.ObterPorId(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] TEntity entity)
        {
            if (_service.ObterPorId(entity.Id) != null) return CustomResponse.RegistroJaCadastrado();

            try
            {
                _service.Inserir(entity);
                return CreatedAtAction(nameof(Post), new { id = entity.Id }, entity);
            }
            catch (ValidationException e)
            {
                return BadRequest(e.Errors);
            }
            catch (Exception e)
            {
                return BadRequest(e);
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

            if (entity == null) return CustomResponse.RegistroNaoEncontrado();

            _service.Deletar(entity);
            return NoContent();
        }
    }
}
