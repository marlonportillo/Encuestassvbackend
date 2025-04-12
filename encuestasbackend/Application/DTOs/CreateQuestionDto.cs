namespace encuestasbackend.Application.DTOs
{
    public class CreateQuestionDto
    {
        public Guid SurveyId { get; set; }
        public string QuestionText { get; set; } = null!;
        public string QuestionType { get; set; } = null!;
        public int? OrderIndex { get; set; }
        public bool IsRequired { get; set; }
    }
}
