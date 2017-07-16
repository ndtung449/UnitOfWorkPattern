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

    public class OrderService : BaseService<Order, OrderDto>, IOrderService
    {
        public OrderService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        protected override IGenericRepository<Order> _reponsitory => _unitOfWork.OrderRepository;

        public async Task SubmitAsync(string createBy, IEnumerable<OrderDetailsDto> orderDetails)
        {
            var orderDto = new OrderDto
            {
                CreatedAt = DateTime.Now,
                CreatedBy = createBy,
                Sku = Guid.NewGuid().ToString("n").Substring(0, 6)
            };

            var orderEntity = DtoToEntity(orderDto);

            _unitOfWork.OrderRepository.Add(orderEntity);

            foreach(var details in orderDetails)
            {
                details.Order = orderEntity;
                var detailsEntity = Mapper.Map<OrderDetails>(details);
                _unitOfWork.OrderDetailsRepository.Add(detailsEntity);
            }

            await _unitOfWork.SaveAsync();
        }
    }
}
