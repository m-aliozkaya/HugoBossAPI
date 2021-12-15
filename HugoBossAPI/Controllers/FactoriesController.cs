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
    public class FactoriesController : ControllerBase
    {
        IFactoryService _factoryService;

        public FactoriesController(IFactoryService factoryService)
        {
            _factoryService = factoryService;
        }

        [HttpGet("getfactorybyid")]
        public IActionResult GetFactoryById(int id)
        {
            var result = _factoryService.GetFactoryById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Factory factory)
        {
            var result = _factoryService.Add(factory);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
