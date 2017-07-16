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
            
            CreateMap<Order, OrderDto>();
            CreateMap<OrderDetails, OrderDetailsDto>();

            #endregion

            #region Dto to Entity
            
            CreateMap<OrderDto, Order>();
            CreateMap<OrderDetailsDto, OrderDetails>();

            #endregion
        }
    }
}
