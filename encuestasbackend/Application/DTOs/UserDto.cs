namespace encuestasbackend.Application.DTOs
{
    public class UserDto
    {
        public Guid UserId { get; set; }
        public string Email { get; set; } = null!;
        public string? DisplayName { get; set; }
    }
}
