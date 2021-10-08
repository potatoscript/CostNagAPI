using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CostNAGAPI.Models;
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
        public IActionResult AddProcess(ProcessVM process)
        {
            _processService.AddProcess(process);

            return Ok();
        }

        [HttpGet("get-process-by-docno/{id}")]
        public IActionResult GetProcessByDocNo(string id)
        {
            var process = _processService.GetProcessByDocNo(id);

            return Ok(process);
        }

        [HttpGet("get-process-master")]
        public IActionResult GetProcessMaster()
        {
            var process = _processService.GetProcessMaster();

            return Ok(process);
        }

        [HttpGet("get-process-by-id/{id}")]
        public IActionResult GetProcessById(int id)
        {
            var process = _processService.GetProcessById(id);

            return Ok(process);
        }

        [HttpPost("update-process-by-id/{id}")]
        public IActionResult UpdateProcessById(int id, Process process)
        {
            var updateCost = _processService.UpdateProcessById(id, process);

            return Ok(updateCost);
        }


        [HttpPost("delete-process-by-id/{id}")]
        public IActionResult DeleteProcessById(int id)
        {
            _processService.DeleteProcessById(id);

            return Ok();
        }

    }
}





