namespace encuestasbackend.models
{
    public class Response
    {

        public Guid ResponseId { get; set; }
        public Guid ParticipantId { get; set; }
        public Guid QuestionId { get; set; }
        public string? ResponseText { get; set; }
        public DateTime CreatedAt { get; set; }

        public Participant Participant { get; set; } = null!;
        public Question Question { get; set; } = null!;
        public ICollection<ResponseOption> ResponseOptions { get; set; } = new List<ResponseOption>();
    }
}
