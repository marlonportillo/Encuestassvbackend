namespace encuestasbackend.Application.DTOs
{
    public class CreateOptionDto
    {
        public Guid QuestionId { get; set; }
        public string OptionText { get; set; } = null!;
        public int? OrderIndex { get; set; }
    }
}
