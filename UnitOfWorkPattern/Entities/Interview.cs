namespace UnitOfWorkPattern.Api.Entities
{
    public class Interview
    {
        public int Id { get; set; }
        public int SetupId { get; set; }
        public string Comment { get; set; }
        public string Strengths { get; set; }
        public int GeneralRating { get; set; }
    }
}
