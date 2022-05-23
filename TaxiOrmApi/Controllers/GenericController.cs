using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using TaxiOrmApi.Controllers.CustomResponses;
using TaxiOrmApi.Dtos;
using TaxiOrmApi.Services.Interfaces;

namespace TaxiOrmApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<TEntityDto> : ControllerBase where TEntityDto : EntityDto
    {
        private IGenericService<TEntityDto> _service;

        public GenericController(IGenericService<TEntityDto> service)
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
        public IActionResult Post([FromBody] TEntityDto entityDto)
        {
            if (_service.ObterPorId(entityDto.Id) != null) return CustomResponse.RegistroJaCadastrado();

            try
            {
                _service.Inserir(entityDto);
                return CreatedAtAction(nameof(Post), new { id = entityDto.Id }, entityDto);
            }
            catch (ValidationException e)
            {
                var errorMessages = e.Errors.Select(e => new { Propriedade = e.PropertyName, Mensagem = e.ErrorMessage });

                return BadRequest(errorMessages);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] TEntityDto entityDto)
        {
            entityDto.Id = id;

            try
            {
                if (_service.ObterPorId(id) != null)
                {
                    _service.Atualizar(entityDto);
                    return NoContent();
                }

                _service.Inserir(entityDto);
                return CreatedAtAction(nameof(Put), new { id = entityDto.Id }, entityDto);
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
