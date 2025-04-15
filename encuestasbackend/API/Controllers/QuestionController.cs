using encuestasbackend.Application.DTOs;
using encuestasbackend.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace encuestasbackend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionService _questionService;

        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }
        // POST: api/question
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CreateQuestionDto dto)
        {
            var questionId = await _questionService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetBySurveyIdAsync), new { surveyId = dto.SurveyId }, questionId);
        }

        // GET: api/question/by-survey/{surveyId}
        [HttpGet("by-survey/{surveyId}")]
        public async Task<IActionResult> GetBySurveyIdAsync(Guid surveyId)
        {
            var questions = await _questionService.GetBySurveyIdAsync(surveyId);
            return Ok(questions);
        }
    }
}
