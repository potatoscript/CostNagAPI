using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CostNAG.Models;
using CostNAGAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CostNAGAPI
{
    public class Startup
    {
        public string ConnectionString { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            ConnectionString = Configuration.GetConnectionString("DbContextConnection");
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            
            //Configure DBContext with SQL
            services.AddDbContext<CostDbContext>(options => options.UseNpgsql(ConnectionString));
            
            services.AddTransient<CostService>();
            services.AddTransient<ProcessService>();
            services.AddTransient<ProcessMasterService>();
            services.AddTransient<CostProcessService>();
            services.AddTransient<RubberService>();
            services.AddTransient<ToolingService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
       
                endpoints.MapControllers();
            });
        }
    }
}
