namespace encuestasbackend.models
{
    public class ResponseOption
    {
        public Guid ResponseOptionId { get; set; }
        public Guid ResponseId { get; set; }
        public Guid OptionId { get; set; }

        public Response Response { get; set; } = null!;
        public Option Option { get; set; } = null!;
    }
}
