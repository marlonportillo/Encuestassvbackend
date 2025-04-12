namespace encuestasbackend.Application.DTOs
{
    public class CreateParticipantDto
    {
        public Guid SurveyId { get; set; }
        public string? DisplayName { get; set; }
        public bool IsAnonymous { get; set; }
    }
}
