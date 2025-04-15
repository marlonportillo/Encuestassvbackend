using encuestasbackend.Application.DTOs;
using encuestasbackend.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace encuestasbackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResponseController : ControllerBase
    {
        private readonly IResponseService _responseService;

        public ResponseController(IResponseService responseService)
        {
            _responseService = responseService;
        }

        // POST: api/response
        [HttpPost]
        public async Task<IActionResult> SubmitResponseAsync([FromBody] CreateResponseDto dto)
        {
            var responseId = await _responseService.SubmitResponseAsync(dto);
            return CreatedAtAction(nameof(GetByQuestionIdAsync), new { questionId = dto.QuestionId }, responseId);
        }

        // GET: api/response/by-question/{questionId}
        [HttpGet("by-question/{questionId}")]
        public async Task<IActionResult> GetByQuestionIdAsync(Guid questionId)
        {
            var responses = await _responseService.GetByQuestionIdAsync(questionId);
            return Ok(responses);
        }

        //// GET: api/response/by-participant/{participantId}
        //[HttpGet("by-participant/{participantId}")]
        //public async Task<IActionResult> GetByParticipantIdAsync(Guid participantId)
        //{
        //    var responses = await _responseService.GetByParticipantIdAsync(participantId);
        //    return Ok(responses);
        //}
    }
}
