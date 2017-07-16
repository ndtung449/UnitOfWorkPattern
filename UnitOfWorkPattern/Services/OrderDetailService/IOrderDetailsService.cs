namespace UnitOfWorkPattern.Api.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using UnitOfWorkPattern.Api.Dtos;
    using UnitOfWorkPattern.Api.Entities;

    public interface IOrderDetailsService : IBaseService<OrderDetails, OrderDetailsDto>
    {
        Task SubmitAsync(string createBy, IEnumerable<OrderDetailsDto> orderDetails);
    }
}
