namespace UnitOfWorkPattern.Api.Entities
{
    public class CompetencyRating
    {
        public int Id { get; set; }
        public int SetupId { get; set; }
        public int CompetencyId { get; set; }
        public int Rating { get; set; }
    }
}
