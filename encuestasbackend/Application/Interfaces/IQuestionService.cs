using encuestasbackend.Application.DTOs;

namespace encuestasbackend.Application.Interfaces
{
    public interface IQuestionService
    {
        Task<Guid> CreateAsync(CreateQuestionDto dto);
        Task<IEnumerable<QuestionDto>> GetBySurveyIdAsync(Guid surveyId)
    }
}
