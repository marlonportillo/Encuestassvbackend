namespace encuestasbackend.Application.DTOs
{
    public class QuestionDto
    {
        public Guid QuestionId { get; set; }
        public string QuestionText { get; set; } = null!;
        public string QuestionType { get; set; } = null!;
        public bool IsRequired { get; set; }
    }
}
