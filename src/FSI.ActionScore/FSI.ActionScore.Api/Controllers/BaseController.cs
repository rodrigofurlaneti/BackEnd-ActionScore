using FSI.ActionScore.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FSI.ActionScore.Api.Controllers
{
    [ApiController]
    public abstract class BaseController<TDto, TService> : ControllerBase
        where TDto : class
        where TService : IBaseService<TDto>
    {
        protected readonly TService Service;

        protected BaseController(TService service)
        {
            Service = service;
        }

        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<TDto>>> GetAllAsync()
        {
            var result = await Service.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public virtual async Task<ActionResult<TDto>> GetByIdAsync(int id)
        {
            var dto = await Service.GetByIdAsync(id);
            if (dto is null)
            {
                return NotFound();
            }

            return Ok(dto);
        }

        [HttpPost]
        public virtual async Task<ActionResult<int>> CreateAsync([FromBody] TDto dto)
        {
            var id = await Service.InsertAsync(dto);
            return CreatedAtAction(nameof(GetByIdAsync), new { id }, id);
        }

        [HttpPut("{id:int}")]
        public virtual async Task<ActionResult> UpdateAsync(int id, [FromBody] TDto dto)
        {
            var updated = await Service.UpdateAsync(id, dto);
            if (!updated)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public virtual async Task<ActionResult> DeleteAsync(int id)
        {
            var deleted = await Service.DeleteAsync(id);
            if (!deleted)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
