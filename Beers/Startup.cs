using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Drinks.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Drinks
{
    public class Startup
    {
         public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<IBeerData, InMemoryBeerData>();
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
