using Business.Abstract;
using Entities;
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
    public class FactoryProductsController : ControllerBase
    {
        IFactoryProductService _factoryProductService;

        public FactoryProductsController(IFactoryProductService factoryProductService)
        {
            _factoryProductService = factoryProductService;
        }

        [HttpPost("add")]
        public IActionResult AddFactoryProduct(FactoryProduct factoryProduct)
        {
            var result = _factoryProductService.Add(factoryProduct);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
