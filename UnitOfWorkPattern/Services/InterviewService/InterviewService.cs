namespace UnitOfWorkPattern.Api.Services
{
    using global::AutoMapper;
    using System;
    using System.Threading.Tasks;
    using UnitOfWorkPattern.Api.Dtos;
    using UnitOfWorkPattern.Api.Entities;
    using UnitOfWorkPattern.Api.Repositories;
    using UnitOfWorkPattern.Api.UnitOfWork;

        public class InterviewService : BaseService<Interview, InterviewDto>, IInterviewService
        {
            public InterviewService(IUnitOfWork unitOfWork) : base(unitOfWork)
            {
            }

            protected override IGenericRepository<Interview> _reponsitory => _unitOfWork.InterviewRepository;

            public async Task SubmitAsync(InterviewDto InterviewDto)
            {
                var interview = DtoToEntity(InterviewDto);
                _unitOfWork.InterviewRepository.Add(interview);

                foreach (var rating in InterviewDto.Ratings)
                {
                    _unitOfWork.CompetencyRatingRepository.Add(
                        Mapper.Map<CompetencyRatingDto, CompetencyRating>(rating));
                }

                await _unitOfWork.SaveAsync();
            }
        }
}
