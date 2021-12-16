using Business.Abstract;
using Entities.Concrete;
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
    public class FactoryOrdersController : ControllerBase
    {
        IFactoryOrderService _FactoryOrderService;

        public FactoryOrdersController(IFactoryOrderService FactoryOrderService)
        {
            _FactoryOrderService = FactoryOrderService;
        }


        [HttpGet("getFactoryOrdersByFactoryId")]
        public IActionResult GetFactoryOrdersByFactoryId(int FactoryOrderId)
        {
            var result = _FactoryOrderService.GetFactoryOrderById(FactoryOrderId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("updateFactoryOrderAmountById")]
        public IActionResult UpdateFactoryOrderAmountById(int id, int amount)
        {
            var result = _FactoryOrderService.UpdateFactoryOrderAmountById(id, amount);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
