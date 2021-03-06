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

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cost_Process>()
                .HasOne(a => a.Cost)
                .WithMany(b => b.Cost_Processes)
                .HasForeignKey(c => c.CostId);

            modelBuilder.Entity<Cost_Process>()
                .HasOne(a => a.Process)
                .WithMany(b => b.Cost_Processes)
                .HasForeignKey(c => c.ProcessId);
        }

        */

        public DbSet<Cost> Costs { get; set; }
        public DbSet<Process> Processes { get; set; }
        public DbSet<ProcessMaster> ProcessesMaster { get; set; }
        public DbSet<CostProcess> CostsProcesses { get; set; }
        public DbSet<Rubber> Rubbers { get; set; }
        public DbSet<Tooling> Toolings { get; set; }

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
