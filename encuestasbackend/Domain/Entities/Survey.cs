

namespace encuestasbackend.Domain.Entities
{
    public class Survey
    {
        public Guid SurveyId { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsLive { get; set; }
        public DateTime CreatedAt { get; set; }

        public User User { get; set; } = null!;
        public ICollection<Question> Questions { get; set; } = new List<Question>();
        public ICollection<Participant> Participants { get; set; } = new List<Participant>();
    }
}
