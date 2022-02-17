using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using CostNAGAPI.Models;
using CostNAGAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CostNAGAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToolingController : ControllerBase
    {

        public ToolingService _toolingService;
        public ToolingController(ToolingService toolingService)
        {
            _toolingService = toolingService;
        }

        [HttpGet("get-all-toolings")]
        public IActionResult GetAllToolings()
        {
            var allToolings = _toolingService.GetAllTooling();

            return Ok(allToolings);
        }

    }
}