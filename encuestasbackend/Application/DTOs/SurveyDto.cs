namespace encuestasbackend.Application.DTOs
{
    public class SurveyDto
    {
        public Guid SurveyId { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsLive { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
