using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderServices;

        public OrdersController(IOrderService orderServices)
        {
            _orderServices = orderServices;
        }
        [HttpGet("TotalOrderCount")]
        public IActionResult TotalOrderCount()
        {
            return Ok(_orderServices.TTotalOrderCount());
        }

        [HttpGet("ActiveOrderCount")]
        public IActionResult ActiveOrderCount()
        {
            return Ok(_orderServices.TActiveOrderCount());
        }
        [HttpGet("LastOrderPrice")]
        public IActionResult LastOrderPrice()
        {
            return Ok(_orderServices.TLastOrderPrice());
        }
        [HttpGet("TodayTotalPrice")]
        public IActionResult TodayTotalPrice()
        {
            return Ok(_orderServices.TTodayTotalPrice());
        }
    }
}
