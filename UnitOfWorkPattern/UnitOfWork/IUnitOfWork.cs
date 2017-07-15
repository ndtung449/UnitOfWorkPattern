namespace UnitOfWorkPattern.Api.UnitOfWork
{
    using System;
    using System.Threading.Tasks;
    using UnitOfWorkPattern.Api.Entities;
    using UnitOfWorkPattern.Api.Repositories;

    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<CompetencyRating> CompetencyRatingRepository { get; }
        IGenericRepository<Interview> InterviewRepository { get; }
        Task SaveAsync();
    }
}
