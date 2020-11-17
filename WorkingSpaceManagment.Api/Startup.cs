using HotChairsApp.BL;
using HotChairsApp.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkingSpaceManagment.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)


        {


            services.Configure<ConnectionConfigurations>(Configuration.GetSection(nameof(ConnectionConfigurations)));

            services.AddSingleton<IConnectionConfigurations>(x => 
            x.GetRequiredService<IOptions<ConnectionConfigurations>>().Value);


            services.AddSingleton<MainService>();
            services.AddSingleton<EmployeesService>();
            services.AddSingleton<OrdersService>();
            services.AddSingleton<WorkSlotsService>();

            services.AddControllers()
                .AddNewtonsoftJson(options => options.UseMemberCasing());


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

            
            app.UseCors(options => options.AllowAnyOrigin());
        }
    }
}
