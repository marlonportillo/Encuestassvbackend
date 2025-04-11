namespace encuestasbackend.models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string? DisplayName { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<Survey> Surveys { get; set; } = new List<Survey>();
    }
}
