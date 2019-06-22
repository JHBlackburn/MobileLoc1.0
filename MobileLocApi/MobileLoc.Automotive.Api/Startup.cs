using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MobileLoc.Automotive.Domain.Dtos;
using MobileLoc.Automotive.Domain.Queries;
using MobileLoc.Automotive.Persistence.Repositories.Models.SqlServer;
using System.Collections.Generic;

namespace MobileLoc.Automotive.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            var connection = @"Server=localhost;Database=MobileLoc;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<MobilelocContext>(options => options.UseSqlServer(connection));

            services.AddScoped<IRequestHandler<GetMakes, IEnumerable<GetMakesDto>>, GetMakesHandler>();
            services.AddMediatR(typeof(Startup).Assembly, typeof(GetMakes).Assembly);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}