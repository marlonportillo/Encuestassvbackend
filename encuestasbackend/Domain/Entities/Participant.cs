
namespace encuestasbackend.Domain.Entities
{
    public class Participant
    {
        public Guid ParticipantId { get; set; }
        public Guid SurveyId { get; set; }
        public string? DisplayName { get; set; }
        public bool IsAnonymous { get; set; }
        public DateTime JoinedAt { get; set; }

        public Survey Survey { get; set; } = null!;
        public ICollection<Response> Responses { get; set; } = new List<Response>();
    }
}
