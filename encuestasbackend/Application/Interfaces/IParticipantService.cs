using encuestasbackend.Application.DTOs;

namespace encuestasbackend.Application.Interfaces
{
    public interface IParticipantService
    {
        Task<Guid> RegisterAsync(CreateParticipantDto dto);
        Task<ParticipantDto?> GetByIdAsync(Guid id);
    }
}
