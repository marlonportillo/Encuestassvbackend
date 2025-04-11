namespace encuestasbackend.models
{
    public class Question
    {
        public Guid QuestionId { get; set; }
        public Guid SurveyId { get; set; }
        public string QuestionText { get; set; } = null!;
        public string QuestionType { get; set; } = null!; // Ej: single-choice, multi-choice, open-ended
        public int? OrderIndex { get; set; }
        public bool IsRequired { get; set; }
        public DateTime CreatedAt { get; set; }

        public Survey Survey { get; set; } = null!;
        public ICollection<Option> Options { get; set; } = new List<Option>();
        public ICollection<Response> Responses { get; set; } = new List<Response>();
    }
}
