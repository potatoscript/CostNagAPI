using System;
using System.Collections.Generic;
using System.Linq;
using CostNAG.Models;
using CostNAGAPI.Models;
using CostNAGAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace CostNAGAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CostController : ControllerBase
    {

        public CostService _costService;

        public CostController(CostService costService)
        {
            _costService = costService;
        }

        [HttpGet("get-all-costs")]
        public IActionResult GetAllCosts()
        {
            var allCosts = _costService.GetAllCost();

            return Ok(allCosts);
        }

        [HttpGet("get-all-docno")]
        public IActionResult GetAllDocNo()
        {
            var allCosts = _costService.GetAllDocNo();

            return Ok(allCosts);
        }


        [HttpGet("get-cost-by-page/{page}")]
        public IActionResult GetCostByPage(int page)
        {
            var cost = _costService.GetCostByPage(page);

            return Ok(cost);
        }


        [HttpGet("get-cost-by-search/{doc}")]
        public IActionResult GetCostBySearch(string doc)
        {
            var cost = _costService.GetCostBySearch(doc);

            return Ok(cost);
        }

        [HttpGet("get-cost-by-id/{id}")]
        public IActionResult GetCostById(int id)
        {
            var cost = _costService.GetCostById(id);

            return Ok(cost);
        }

        [HttpPost("add-cost")]
        public IActionResult AddCost(Cost cost)
        {
            _costService.AddCost(cost);

            return Ok();
        }



        [HttpPost("update-cost-by-id/{id}")]
        public IActionResult UpdateCostById(int id, Cost cost)
        {
            var updateCost = _costService.UpdateCostById(id, cost);

            return Ok(updateCost);
        }


        [HttpPost("delete-cost-by-id/{id}")]
        public IActionResult DeleteCostById(int id)
        {
            _costService.DeleteCostById(id);

            return Ok();
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