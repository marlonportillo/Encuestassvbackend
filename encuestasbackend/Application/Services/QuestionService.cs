using encuestasbackend.Application.DTOs;
using encuestasbackend.Application.Interfaces;

namespace encuestasbackend.Application.Services
{
    public class QuestionService : IQuestionService
    {
        public Task<Guid> CreateAsync(CreateQuestionDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<QuestionDto>> GetBySurveyIdAsync(Guid surveyId)
        {
            throw new NotImplementedException();
        }
    }
}
