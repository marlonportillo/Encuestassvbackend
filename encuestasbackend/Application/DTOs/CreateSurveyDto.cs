namespace encuestasbackend.Application.DTOs
{
    public class CreateSurveyDto
    {
        public Guid UserId { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
    }
}
