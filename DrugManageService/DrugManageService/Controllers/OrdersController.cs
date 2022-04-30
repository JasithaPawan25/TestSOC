using DrugManageService.Data.Services;
using DrugManageService.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrugManageService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private OrdersService _ordersService;

        public OrdersController(OrdersService ordersService)
        {
            _ordersService = ordersService;

        }


        [HttpGet("all-orders")]

       // public List<Order> GetAllOrders() => _context.Orders.ToList();

        public IActionResult GetAllOrders()
        {
            var allOrders = _ordersService.GetAllOrders();
            return Ok(allOrders);
        }

        [HttpGet("get-order-by-id/{id}")]

        public IActionResult GetOrderById(int id)
        {
            var Order = _ordersService.GetOrderById(id);
            return Ok(Order);
        }



        [HttpPost("add-Order")]

        public IActionResult AddOrder([FromBody] OrderVM order)
        {
            _ordersService.AddOrder(order);
            return Ok();

        }


        [HttpPut("update-order-by-id/{id}")]

        public IActionResult UpdateOrderById(int id, [FromBody] OrderVM order)
        {
            var updatedOrder = _ordersService.UpdateOrderById(id, order);
            return Ok(updatedOrder);

        }

        [HttpDelete("delete-order-by-id/{id}")]
        public IActionResult DeleteOrderById(int id)
        {
            _ordersService.DeleteOrderById(id);
            return Ok();

        }



    }
}
