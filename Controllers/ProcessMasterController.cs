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
    public class ProcessMasterController : Controller
    {
        private ProcessMasterService _processMasterService;

        public ProcessMasterController(ProcessMasterService processMasterService)
        {
            _processMasterService = processMasterService;
        }

        [HttpGet("get-all-processesmaster")]
        public IActionResult GetAllProcessesMaster()
        {
            var allCosts = _processMasterService.GetAllProcessesMaster();

            return Ok(allCosts);
        }


        [HttpPost("add-processmaster")]
        public IActionResult AddProcessMaster(ProcessMasterVM process)
        {
            _processMasterService.AddProcessMaster(process);

            return Ok();
        }

        [HttpGet("get-processmaster-by-od/{od}")]
        public IActionResult GetProcessMasterByOD(double od)
        {
            var process = _processMasterService.GetProcessMasterByOD(od);

            return Ok(process);
        }

        [HttpGet("get-processname-by-od/{od}")]
        public IActionResult GetProcessNameByOD(double od)
        {
            var process = _processMasterService.GetProcessNameByOD(od);

            return Ok(process);
        }


        [HttpGet("get-processmaster-by-id/{id}")]
        public IActionResult GetProcessMasterById(int id)
        {
            var data = _processMasterService.GetProcessMasterById(id);

            return Ok(data);
        }

        [HttpPost("update-processmaster-by-id/{id}")]
        public IActionResult UpdateProcessMasterById(int id, ProcessMasterVM processmaster)
        {
            var updateData = _processMasterService.UpdateProcessMasterById(id, processmaster);

            return Ok(updateData);
        }


        [HttpPost("delete-processmaster-by-id/{id}")]
        public IActionResult DeleteProcessMasterById(int id)
        {
            _processMasterService.DeleteProcessMasterById(id);

            return Ok();
        }
    }
}