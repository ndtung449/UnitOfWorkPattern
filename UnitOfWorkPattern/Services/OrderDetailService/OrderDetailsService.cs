namespace UnitOfWorkPattern.Api.Services
{
    using global::AutoMapper;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using UnitOfWorkPattern.Api.Dtos;
    using UnitOfWorkPattern.Api.Entities;
    using UnitOfWorkPattern.Api.Repositories;
    using UnitOfWorkPattern.Api.UnitOfWork;

    public class OrderDetailsService : BaseService<OrderDetails, OrderDetailsDto>, IOrderDetailsService
    {
        public OrderDetailsService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IGenericRepository<OrderDetails> _reponsitory => _unitOfWork.OrderDetailsRepository;

        public async Task SubmitAsync(string createBy, IEnumerable<OrderDetailsDto> orderDetails)
        {
            var orderDto = new OrderDto
            {
                CreatedAt = DateTime.Now,
                CreatedBy = createBy,
                Sku = Guid.NewGuid().ToString("n").Substring(0, 6)
            };

            var orderEntity = Mapper.Map<Order>(orderDto);

            _unitOfWork.OrderRepository.Add(orderEntity);

            foreach (var details in orderDetails)
            {
                details.Order = orderEntity;
                details.CreatedAt = DateTime.Now;
                _unitOfWork.OrderDetailsRepository.Add(DtoToEntity(details));
            }

            await _unitOfWork.SaveAsync();
        }
    }
}
