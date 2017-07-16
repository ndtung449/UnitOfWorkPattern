namespace UnitOfWorkPattern.Api.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using UnitOfWorkPattern.Api.Dtos;
    using UnitOfWorkPattern.Api.Entities;

    public interface IOrderService : IBaseService<Order, OrderDto>
    {
        Task SubmitAsync(string createBy, IEnumerable<OrderDetailsDto> orderDetails);
    }
}
