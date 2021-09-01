using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CostNAG.Models;
using Microsoft.AspNetCore.Mvc;

namespace CostNAGAPI.Controllers
{
    [Route("api/[controller]")]
    public class CostController : Controller
    {
        private CostDbContext _context;

        public CostController(CostDbContext context)
        {
            _context = context;
        }


    }
}