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

    public class CostProcessController : Controller
    {

        private CostProcessService _processService;

        public CostProcessController(CostProcessService processService)
        {
            _processService = processService;
        }

        [HttpPost("add-costprocess")]
        public IActionResult AddProcess(CostProcessVM process)
        {
            _processService.AddCostProcess(process);

            return Ok();
        }


        [HttpGet("get-costprocess-by-docno/{id}")]
        public IActionResult GetCostProcessByDocNo(string id)
        {
            var process = _processService.GetCostProcessByDocNo(id);

            return Ok(process);
        }

        [HttpGet("get-costprocess-by-type/{type}")]
        public IActionResult GetCostProcessByType(string type)
        {
            var process = _processService.GetCostProcessByType(type);

            return Ok(process);
        }

        [HttpPost("delete-costprocess-by-id/{id}")]
        public IActionResult DeleteCostProcessById(int id)
        {
            _processService.DeleteCostProcessById(id);

            return Ok();
        }
    }
}