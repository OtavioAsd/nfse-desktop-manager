using Microsoft.AspNetCore.Mvc;
using NFSeApi.Dtos;
using NFSeApi.Services;

namespace NFSeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NFSeController : ControllerBase
    {
        private readonly NFSeService _service;

        public NFSeController(NFSeService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] InvoiceDto dto)
        {
            var result = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetAll), new { id = result.Id }, result);
        }
    }
}