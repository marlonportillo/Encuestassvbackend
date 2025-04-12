using encuestasbackend.Application.DTOs;
using encuestasbackend.Application.Interfaces;

namespace encuestasbackend.Application.Services
{
    public class ResponseService : IResponseService
    {
        public Task<IEnumerable<ResponseDto>> GetByQuestionIdAsync(Guid questionId)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> SubmitResponseAsync(CreateResponseDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
