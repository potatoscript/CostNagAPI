using CostNAG.Models;
using CostNAGAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CostNAGAPI.Services
{
    public class ToolingService
    {

        private CostDbContext _context;
        public ToolingService(CostDbContext context)
        {
            _context = context;
        }

        public List<Tooling> GetAllTooling() =>
            _context.Toolings.OrderBy(n => n.description).ToList();
    }
}
