using encuestasbackend.Application.DTOs;
using encuestasbackend.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace encuestasbackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionController : ControllerBase
    {
        private readonly IOptionService _optionService;

        public OptionController(IOptionService optionService)
        {
            _optionService = optionService;
        }
        // POST: api/option
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateOptionDto dto)
        {
            var optionId = await _optionService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetByQuestionIdAsync), new { questionId = dto.QuestionId }, optionId);
        }

        // GET: api/option/by-question/{questionId}
        [HttpGet("by-question/{questionId}")]
        public async Task<IActionResult> GetByQuestionIdAsync(Guid questionId)
        {
            var options = await _optionService.GetByQuestionIdAsync(questionId);
            return Ok(options);
        }
    }
}
