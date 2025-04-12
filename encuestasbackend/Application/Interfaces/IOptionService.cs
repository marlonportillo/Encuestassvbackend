using encuestasbackend.Application.DTOs;

namespace encuestasbackend.Application.Interfaces
{
    public interface IOptionService
    {
        Task<Guid> CreateAsync(CreateOptionDto dto);
        Task<IEnumerable<OptionDto>> GetByQuestionIdAsync(Guid questionId);
    }
}
