using CostNAGAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CostNAG.Models
{
    public class CostDbContext : DbContext
    {

        //public IConfiguration _configuration;

        //public CostDbContext(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}

        public CostDbContext(DbContextOptions<CostDbContext> options):base(options)
        {

        }

        public DbSet<Cost> Costs { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    string connstring = String.Format(
        //        _configuration
        //        .GetSection("ConnectionStrings")
        //        .GetSection("DbContextConnection").Value);

        //    optionsBuilder.UseNpgsql(connstring);

        //}

    }
}
