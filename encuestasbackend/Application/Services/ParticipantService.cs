using encuestasbackend.Application.DTOs;
using encuestasbackend.Application.Interfaces;

namespace encuestasbackend.Application.Services
{
    public class ParticipantService : IParticipantService
    {
        public Task<ParticipantDto?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> RegisterAsync(CreateParticipantDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
