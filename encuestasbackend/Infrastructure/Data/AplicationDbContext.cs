using encuestasbackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace encuestasbackend.Infrastructure.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users => Set<User>();
        public DbSet<Survey> Surveys => Set<Survey>();
        public DbSet<Question> Questions => Set<Question>();
        public DbSet<Option> Options => Set<Option>();
        public DbSet<Participant> Participants => Set<Participant>();
        public DbSet<Response> Responses => Set<Response>();
        public DbSet<ResponseOption> ResponseOptions => Set<ResponseOption>();

        protected AplicationDbContext()
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AplicationDbContext).Assembly);
        }
    }
}
