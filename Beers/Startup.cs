using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Drinks.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Drinks
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

         public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<DrinksDbContext>(options => options.UseSqlServer(_configuration.GetConnectionString("Drinks")));
            services.AddScoped<IBeerData, BeerRepository>();
            services.AddScoped<IWhiskeyData, WhiskeyRepository>();
        }

        public void Configure(IApplicationBuilder app,
                             IHostingEnvironment env,
                             IConfiguration configuration)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(ConfigureRoutes);
        }

        private void ConfigureRoutes(IRouteBuilder routerBuilder)
        {
            routerBuilder.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}");
        }
    }
}
