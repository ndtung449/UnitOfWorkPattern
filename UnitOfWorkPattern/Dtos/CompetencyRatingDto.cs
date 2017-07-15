namespace UnitOfWorkPattern.Api.Dtos
{
    public class CompetencyRatingDto
    {
        public string Id { get; set; }
        public int SetupId { get; set; }
        public int InterviewId { get; set; }
        public int Rating { get; set; }
    }
}
