using encuestasbackend.Application.DTOs;

namespace encuestasbackend.Application.Interfaces
{
    public interface IResponseService
    {
        Task<Guid> SubmitResponseAsync(CreateResponseDto dto);
        Task<IEnumerable<ResponseDto>> GetByQuestionIdAsync(Guid questionId);
    }
}
