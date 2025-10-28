using CursoInfoeste.Abstractions.Services;
using CursoInfoeste.Controllers.Base;
using CursoInfoeste.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace CursoInfoeste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TenantController : BaseController
    {
        private readonly ITenantService _service;

        public TenantController(ITenantService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id, CancellationToken cancellationToken)
        {
            var tenant = await _service.Get(id, cancellationToken);
            if (tenant == null)
            {
                return NotFound();
            }
            return Ok(tenant);
        }

        [HttpGet]
        public async Task<IActionResult> List(CancellationToken cancellationToken)
        {
            return Ok(await _service.List(cancellationToken));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateTenantRequest request, CancellationToken cancellationToken)
        {
            var tenant = await _service.Create(request, cancellationToken);
            return CreatedAtAction(nameof(Get), new { id = tenant.Id }, tenant);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateTenantRequest request, CancellationToken cancellationToken)
        {
            var tenant = await _service.Update(id, request, cancellationToken);
            if (tenant == null)
            {
                return NotFound();
            }
            return Ok(tenant);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
        {
            await _service.Delete(id, cancellationToken);
            return NoContent();
        }
    }
}
