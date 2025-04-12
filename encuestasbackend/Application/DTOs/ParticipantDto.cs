namespace encuestasbackend.Application.DTOs
{
    public class ParticipantDto
    {
        public Guid ParticipantId { get; set; }
        public string? DisplayName { get; set; }
        public bool IsAnonymous { get; set; }
        public DateTime JoinedAt { get; set; }
    }
}
