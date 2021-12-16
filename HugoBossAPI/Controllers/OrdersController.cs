using Business.Abstract;
using Entities.Concrete;
using HugoBossAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HugoBossAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("add")]
        public IActionResult AddOrder(OrderModel orderModel)
        {
            var order = new Order
            {
                ProductId = orderModel.ProductId,
                CustomerId = orderModel.CustomerId,
                Priority = orderModel.Priority,
                Amount = orderModel.Amount,
                DeliveryDate = orderModel.DeliveryDate,
                OrderDate = DateTime.Now
            };

            var result = _orderService.Add(order);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getOrderById")]
        public IActionResult GetOrderById(int orderId)
        {
            var result = _orderService.GetOrderById(orderId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getOrders")]
        public IActionResult GetOrders()
        {
            var result = _orderService.GetOrders();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
