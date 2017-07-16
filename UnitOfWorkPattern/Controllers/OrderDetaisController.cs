namespace UnitOfWorkPattern.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using UnitOfWorkPattern.Api.Dtos;
    using UnitOfWorkPattern.Api.Services;

    [Route("api/[controller]")]
    public class OrderDetaisController : Controller
    {
        private readonly IOrderDetailsService _orderDetailsService;

        public OrderDetaisController(IOrderDetailsService orderDetailsService)
        {
            _orderDetailsService = orderDetailsService;
        }

        [HttpPost]
        [Route("{createBy}")]
        public async Task Post(string createBy, [FromBody] IDictionary<string, IEnumerable<OrderDetailsDto>> dic)
        {
            var orderDetailsList = dic["orderDetails"];
            await _orderDetailsService.SubmitAsync(createBy, orderDetailsList);
        }
    }
}
