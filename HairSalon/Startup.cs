using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using HairSalon.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace HairSalon
{
    public class Startup
    {
        public Startup(IWebHostEnvironment env)
        {
        var builder = new ConfigurationBuilder()
            .SetBasePath(env.ContentRootPath)
            .AddJsonFile("appsettings.json");
        Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
        services.AddMvc();

        services.AddEntityFrameworkMySql()
            .AddDbContext<HairSalonContext>(options => options
            .UseMySql(Configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(Configuration["ConnectionStrings:DefaultConnection"])));
        }

        public void Configure(IApplicationBuilder app)
        {
        app.UseDeveloperExceptionPage();
        app.UseRouting();

        app.UseEndpoints(routes =>
        {
            routes.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
        });

        app.UseStaticFiles();
        
        app.Run(async (context) =>
        {
            await context.Response.WriteAsync("Hello World!");
        });
        }
    }
}