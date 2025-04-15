using encuestasbackend.Application.DTOs;
using encuestasbackend.Application.Interfaces;
using encuestasbackend.Domain.Entities;
using encuestasbackend.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

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

        public async Task<bool> DeleteAsync(Guid id)
        {
            var user = await _context.Surveys.FindAsync(id);
            if (user == null) return false;

            _context.Surveys.Remove(user);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<SurveyDto>> GetAllAsync()
        {
            return await _context.Surveys
               .Select(survey => new SurveyDto
               {
                   SurveyId = survey.SurveyId,
                   Title = survey.Title,
                   Description = survey.Description,
                   IsLive = true,
                   CreatedAt = DateTime.UtcNow
               }).ToListAsync();
        }

        public async Task<SurveyDto?> GetByIdAsync(Guid id)
        {
            var survey = await _context.Surveys.FindAsync(id);
            if (survey == null) return null;

            return new SurveyDto
            {
                SurveyId = survey.SurveyId,
                Title = survey.Title,
                Description = survey.Description,
                IsLive = true,
                CreatedAt = DateTime.UtcNow
            };
        }
    }
}
