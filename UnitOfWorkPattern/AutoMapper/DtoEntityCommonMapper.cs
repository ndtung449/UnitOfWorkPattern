namespace UnitOfWorkPattern.Api.AutoMapper
{
    using global::AutoMapper;
    using UnitOfWorkPattern.Api.Dtos;
    using UnitOfWorkPattern.Api.Entities;

    public class DtoEntityCommonMapper : Profile
    {
        public DtoEntityCommonMapper()
        {
            #region Enity To Dto

            CreateMap<CompetencyRating, CompetencyRatingDto>();
            CreateMap<Interview, InterviewDto>();

            #endregion

            #region Dto to Entity

            CreateMap<CompetencyRatingDto, CompetencyRating>();
            CreateMap<InterviewDto, Interview>();

            #endregion
        }
    }
}
