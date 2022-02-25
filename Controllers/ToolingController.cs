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


        [HttpGet("get-tooling-by-od/{od}")]
        public IActionResult GetToolingByOd(int od)
        {
            var data = _toolingService.GetToolingByOd(od);

            return Ok(data);
        }

        [HttpGet("get-tooling-by-id/{id}")]
        public IActionResult GetToolingById(int id)
        {
            var data = _toolingService.GetToolingById(id);

            return Ok(data);
        }



        [HttpPost("add-tooling-data")]
        public IActionResult AddTooling(Tooling tooling)
        {
            _toolingService.AddToolingData(tooling);

            return Ok();
        }


        [HttpPost("update-tooling-by-id/{id}")]
        public IActionResult UpdateToolingById(int id, Tooling tooling)
        {
            var data = _toolingService.UpdateToolingById(id, tooling);

            return Ok(data);
        }


        [HttpPost("delete-tooling-by-id/{id}")]
        public IActionResult DeleteToolingById(int id)
        {
            _toolingService.DeleteToolingById(id);

            return Ok();
        }




    }
}