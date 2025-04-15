using encuestasbackend.Application.DTOs;
using encuestasbackend.Application.Interfaces;
using encuestasbackend.Domain.Entities;
using encuestasbackend.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace encuestasbackend.Application.Services
{
    public class QuestionService : IQuestionService
    {

        private readonly AplicationDbContext _context;

        public QuestionService(AplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Guid> CreateAsync(CreateQuestionDto dto)
        {
            var question = new Question
            {
                QuestionId = Guid.NewGuid(),
                SurveyId = dto.SurveyId,
                QuestionText = dto.QuestionText,
                QuestionType = dto.QuestionType,
                OrderIndex = dto.OrderIndex,
                IsRequired = dto.IsRequired,
                CreatedAt = DateTime.UtcNow
            };

            _context.Questions.Add(question);
            await _context.SaveChangesAsync();

            return question.QuestionId;
        }

        public async Task<IEnumerable<QuestionDto>> GetBySurveyIdAsync(Guid surveyId)
        {
            var questions = await _context.Questions
             .Where(q => q.SurveyId == surveyId)
             .OrderBy(q => q.OrderIndex)
             .ToListAsync();

            return questions.Select(q => new QuestionDto
            {
                QuestionId = q.QuestionId,
                QuestionText = q.QuestionText,
                QuestionType = q.QuestionType,
                IsRequired = q.IsRequired
            });
        }
    }
}
