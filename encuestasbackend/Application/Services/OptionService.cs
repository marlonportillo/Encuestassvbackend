using encuestasbackend.Application.DTOs;
using encuestasbackend.Application.Interfaces;
using encuestasbackend.Domain.Entities;
using encuestasbackend.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace encuestasbackend.Application.Services
{
    public class OptionService : IOptionService
    {
        private readonly AplicationDbContext _context;

        public OptionService(AplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> CreateAsync(CreateOptionDto dto)
        {
            var option = new Option
            {
                OptionId = Guid.NewGuid(),
                QuestionId = dto.QuestionId,
                OptionText = dto.OptionText,
                OrderIndex = dto.OrderIndex ?? 0
            };

            _context.Options.Add(option);
            await _context.SaveChangesAsync();

            return option.OptionId;
        }

        public async Task<IEnumerable<OptionDto>> GetByQuestionIdAsync(Guid questionId)
        {
            var options = await _context.Options
                .Where(o => o.QuestionId == questionId)
                .OrderBy(o => o.OrderIndex)
                .ToListAsync();

            return options.Select(o => new OptionDto
            {
                OptionId = o.OptionId,
                OptionText = o.OptionText
            });
        }
    
}
}
