namespace UnitOfWorkPattern.Api.Services
{
    using UnitOfWorkPattern.Api.Dtos;
    using UnitOfWorkPattern.Api.Entities;
    using UnitOfWorkPattern.Api.Repositories;
    using UnitOfWorkPattern.Api.UnitOfWork;

    public class CompetencyRatingService : BaseService<CompetencyRating, CompetencyRatingDto>, ICompetencyRatingService
    {
        public CompetencyRatingService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IGenericRepository<CompetencyRating> _reponsitory => _unitOfWork.CompetencyRatingRepository;
    }
}
