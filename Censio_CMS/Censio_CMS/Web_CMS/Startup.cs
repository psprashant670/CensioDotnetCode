using System;
using System.IO;
using DataAccess.Data;
using DataAccess.EFCore.Repositories;
using DataAccess.EFCore.UnitOfWorks;
using Domain.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Censio_CMS
{
    public class Startup
    {
        public static string BaseURLAcclimate { get; private set; }
        public static string BaseUrl { get; private set; }
        public static string hrefURL { get; private set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            hrefURL = Configuration.GetSection("hrefURL").Value;
            BaseUrl = Configuration.GetSection("BaseUrl").Value;
            BaseURLAcclimate = Configuration.GetSection("BaseURLAcclimate").Value;
        }
        public static string GethrefURL()
        {
            return Startup.hrefURL;
        }
        public static string GetBaseUrl()
        {
            return Startup.BaseUrl;
        }
        public static string GetBaseURLAcclimate()
        {
            return Startup.BaseURLAcclimate;
        }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddSession();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });
            services.AddDbContext<db_censio_betaContext>(opts => opts.UseMySql(Configuration.GetConnectionString("CensioDB")));
            #region Repositories
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            //services.AddTransient<IDeveloperRepository, DeveloperRepository>();
            //services.AddTransient<IProjectRepository, ProjectRepository>();
            #endregion
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseHttpsRedirection();

            app.UseRouting();
          
            app.UseAuthorization();
            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Login}/{id?}");
            });
        }
    }
}
