namespace encuestasbackend.Domain.Entities
{
    public class Option
    {
        public Guid OptionId { get; set; }
        public Guid QuestionId { get; set; }
        public string OptionText { get; set; } = null!;
        public int? OrderIndex { get; set; }

        public Question Question { get; set; } = null!;
        public ICollection<ResponseOption> ResponseOptions { get; set; } = new List<ResponseOption>();
    }
}
