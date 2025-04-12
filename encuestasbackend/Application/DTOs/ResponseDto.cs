namespace encuestasbackend.Application.DTOs
{
    public class ResponseDto
    {
        public Guid ResponseId { get; set; }
        public string? ResponseText { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
