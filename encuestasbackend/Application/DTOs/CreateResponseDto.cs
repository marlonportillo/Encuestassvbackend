namespace encuestasbackend.Application.DTOs
{
    public class CreateResponseDto
    {
        public Guid ParticipantId { get; set; }
        public Guid QuestionId { get; set; }
        public string? ResponseText { get; set; }
        public List<Guid>? SelectedOptionIds { get; set; } // Para single/multi-choice
    }
}
