namespace UnitOfWorkPattern.Api.Dtos
{
    using System.Collections.Generic;

    public class InterviewDto
    {
        public string Id { get; set; }
        public int SetupId { get; set; }
        public string Comment { get; set; }
        public string Strengths { get; set; }
        public int GeneralRating { get; set; }
        public IEnumerable<CompetencyRatingDto> Ratings { get; set; }
    }
}
