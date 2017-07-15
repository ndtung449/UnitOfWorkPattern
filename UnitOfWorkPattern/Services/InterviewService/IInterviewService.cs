namespace UnitOfWorkPattern.Api.Services
{
    using System.Threading.Tasks;
    using UnitOfWorkPattern.Api.Dtos;
    using UnitOfWorkPattern.Api.Entities;

    public interface IInterviewService : IBaseService<Interview, InterviewDto>
    {
        Task SubmitAsync(InterviewDto result);
    }
}
