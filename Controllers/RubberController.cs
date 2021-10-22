using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CostNAGAPI.Models;
using CostNAGAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CostNAGAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RubberController : ControllerBase
    {
        public RubberService _rubberService;
        public RubberController(RubberService rubberService)
        {
            _rubberService = rubberService;
        }

        [HttpGet("get-all-rubbers")]
        public IActionResult GetAllRubbers()
        {
            var allRubbers = _rubberService.GetAllRubber();

            return Ok(allRubbers);
        }

        [HttpGet("get-rubber-by-id/{id}")]
        public IActionResult GetRubberById(int id)
        {
            var data = _rubberService.GetRubberById(id);

            return Ok(data);
        }

        [HttpGet("get-rubber-by-name/{name}")]
        public IActionResult GetRubberByName(string name)
        {
            var data = _rubberService.GetRubberByName(name);

            return Ok(data);
        }

        [HttpPost("add-rubber")]
        public IActionResult AddRubber(Rubber rubber)
        {
            _rubberService.AddCost(rubber);

            return Ok();
        }


        [HttpPost("update-rubber-by-id/{id}")]
        public IActionResult UpdateRubberById(int id, Rubber rubber)
        {
            var data = _rubberService.UpdateRubberById(id, rubber);

            return Ok(data);
        }


        [HttpPost("delete-rubber-by-id/{id}")]
        public IActionResult DeleteRubberById(int id)
        {
            _rubberService.DeleteRubberById(id);

            return Ok();
        }






    }
}






