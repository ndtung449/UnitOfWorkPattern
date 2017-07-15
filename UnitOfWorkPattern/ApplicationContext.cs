namespace UnitOfWorkPattern.Api
{
    using Microsoft.EntityFrameworkCore;
    using UnitOfWorkPattern.Api.Entities;

    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<CompetencyRating> CompetencyRatings { get; set; }
        public DbSet<Interview> Interviews { get; set; }
    }
}
