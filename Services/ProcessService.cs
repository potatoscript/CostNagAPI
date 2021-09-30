using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CostNAG.Models;
using CostNAGAPI.Models;
using CostNAGAPI.ViewModels;

namespace CostNAGAPI.Services
{
    public class ProcessService
    {
        private CostDbContext _context;
        public ProcessService(CostDbContext context)
        {
            _context = context;
        }

        public void AddProcess(ProcessVM process)
        {
            var _process = new Process()
            {
                doc_no = process.doc_no

            };

            _context.Processes.Add(_process);
            _context.SaveChanges();


        }



        public Process GetProcessById(string doc_no)
        {
            var _process = _context.Processes
                .Where(n => n.doc_no == doc_no)
                .Select(process => new Process()
                {
                    process_cost = process.process_cost,

                }).FirstOrDefault();

            return _process;
        }



    }
}
