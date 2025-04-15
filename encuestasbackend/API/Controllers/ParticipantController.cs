using encuestasbackend.Application.DTOs;
using encuestasbackend.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace encuestasbackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipantController : ControllerBase
    {
        private readonly IParticipantService _participantService;

        public ParticipantController(IParticipantService participantService)
        {
            _participantService = participantService;
        }

        // POST: api/participant
        [HttpPost]
        public async Task<IActionResult> RegisterAsync([FromBody] CreateParticipantDto dto)
        {
            var participantId = await _participantService.RegisterAsync(dto);
            return CreatedAtAction(nameof(GetByIdAsync), new { id = participantId }, participantId);
        }

        // GET: api/participant/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            var participant = await _participantService.GetByIdAsync(id);
            if (participant == null) return NotFound();
            return Ok(participant);
        }
    }
}
