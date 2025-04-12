using encuestasbackend.Application.DTOs;
using encuestasbackend.Application.Interfaces;

namespace encuestasbackend.Application.Services
{
    public class OptionService : IOptionService
    {
        public Task<Guid> CreateAsync(CreateOptionDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OptionDto>> GetByQuestionIdAsync(Guid questionId)
        {
            throw new NotImplementedException();
        }
    }
}
