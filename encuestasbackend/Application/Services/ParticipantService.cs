using encuestasbackend.Application.DTOs;
using encuestasbackend.Application.Interfaces;
using encuestasbackend.Domain.Entities;
using encuestasbackend.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace encuestasbackend.Application.Services
{
    public class ParticipantService : IParticipantService
    {
        private readonly AplicationDbContext _context;

        public ParticipantService(AplicationDbContext context)
        {
            _context = context;
        }
        public async Task<ParticipantDto?> GetByIdAsync(Guid id)
        {
            var participant = await _context.Participants
               .FirstOrDefaultAsync(p => p.ParticipantId == id);

            if (participant == null)
                return null;

            return new ParticipantDto
            {
                ParticipantId = participant.ParticipantId,
                DisplayName = participant.DisplayName,
                IsAnonymous = participant.IsAnonymous,
                JoinedAt = participant.JoinedAt
            };
        }

        public async Task<Guid> RegisterAsync(CreateParticipantDto dto)
        {
            var participant = new Participant
            {
                ParticipantId = Guid.NewGuid(),
                SurveyId = dto.SurveyId,
                DisplayName = dto.IsAnonymous ? null : dto.DisplayName,
                IsAnonymous = dto.IsAnonymous,
                JoinedAt = DateTime.UtcNow
            };

            _context.Participants.Add(participant);
            await _context.SaveChangesAsync();

            return participant.ParticipantId;
        }
    }
}
