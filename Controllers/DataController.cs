using System;
using System.Collections.Generic;
using System.Linq;
using CostNAG.Models;
using CostNAGAPI.Models;
using CostNAGAPI.Services;
using CostNAGAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;


namespace CostNAGAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : ControllerBase
    {

        public CostService _costService;

        public DataController(CostService costService)
        {
            _costService = costService;
        }

        [HttpGet("get-all-costs")]
        public IActionResult GetAllCosts()
        {
            var allCosts = _costService.GetAllCost();

            return Ok(allCosts);
        }

        [HttpGet("get-cost-by-id/{id}")]
        public IActionResult GetCostById(int id)
        {
            var cost = _costService.GetCostById(id);

            return Ok(cost);
        }

        [HttpPost("add-cost")]
        public IActionResult AddCost([FromBody]CostVM cost)
        {
            _costService.AddCost(cost);

            return Ok();
        }



        [HttpPut("update-cost-by-id/{id}")]
        public IActionResult UpdateCostById(int id, [FromBody]CostVM cost)
        {
            var updateCost = _costService.UpdateCostById(id, cost);

            return Ok(updateCost);
        }

        //public IConfiguration _configuration;


        //public DataController(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}

        //[HttpGet]
        //public IEnumerable<Cost> GetCosts()
        //{
        //    using (var _context = new CostDbContext(_configuration))
        //    {

        //        //Cost cost = _context.Foods.First(a => a.FoodId == 2);

        //        //_context.Foods.Remove(food);

        //        //_context.SaveChanges();

        //        return _context.Costs.ToList();
        //    }
        //}


        //[HttpGet("{id}")]
        //public ActionResult<Cost>GetCost(int id)
        //{
        //    var _context = new CostDbContext(_configuration);

        //    Cost cost = _context.Costs.First(a => a.CostId == 2);

        //    if (cost == null)
        //    {
        //        return NotFound();
        //    }
        //    return cost;
        //}


    }
}