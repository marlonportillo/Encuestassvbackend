using encuestasbackend.Application.DTOs;

namespace encuestasbackend.Application.Interfaces
{
    public interface ISurveyService
    {
        Task<SurveyDto> CreateAsync(CreateSurveyDto dto);
        Task<IEnumerable<SurveyDto>> GetAllAsync();
        Task<SurveyDto?> GetByIdAsync(Guid id);
        Task<bool> DeleteAsync(Guid id);
    }
}
