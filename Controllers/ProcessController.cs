using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CostNAGAPI.Services;
using CostNAGAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CostNAGAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProcessController : ControllerBase
    {
        private ProcessService _processService;

        public ProcessController(ProcessService processService)
        {
            _processService = processService;
        }

        [HttpPost("add-process")]
        public IActionResult AddCost(ProcessVM process)
        {
            _processService.AddProcess(process);

            return Ok();
        }

        [HttpGet("get-process-by-id/{id}")]
        public IActionResult GetProcessById(string id)
        {
            var cost = _processService.GetProcessById(id);

            return Ok(cost);
        }

    }
}





