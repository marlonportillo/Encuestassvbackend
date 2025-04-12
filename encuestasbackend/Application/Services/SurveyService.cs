using encuestasbackend.Application.DTOs;
using encuestasbackend.Application.Interfaces;
using encuestasbackend.Domain.Entities;
using encuestasbackend.Infrastructure.Data;

namespace encuestasbackend.Application.Services
{
    public class SurveyService : ISurveyService
    {
        private readonly AplicationDbContext _context;
        public SurveyService(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task<SurveyDto> CreateAsync(CreateSurveyDto dto)
        {
            var survey = new Survey
            {
                SurveyId = Guid.NewGuid(),
                UserId = dto.UserId,
                Title = dto.Title,
                Description = dto.Description,
                IsLive = true,
                CreatedAt = DateTime.UtcNow
            };
            _context.Surveys.Add(survey);
           await _context.SaveChangesAsync();
            return  new SurveyDto {
            SurveyId = survey.SurveyId,
                Title = survey.Title,
                Description = survey.Description,
                IsLive = true,
                CreatedAt = DateTime.UtcNow
            };
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SurveyDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SurveyDto?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
