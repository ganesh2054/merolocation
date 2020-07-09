using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using VehicleLocation.Models;

namespace VehicleLocation
{
    public class Startup
    {
        private readonly IConfiguration config;
        public Startup(IConfiguration config)
        {
            this.config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentity<IdentityUser, IdentityRole>()
       .AddEntityFrameworkStores<AppDBContext>();
            services.AddDbContextPool<AppDBContext>(options => options.UseSqlServer(config.GetConnectionString("LocationDbConnection")));
            services.AddMvc().AddXmlSerializerFormatters();
            services.AddHttpContextAccessor();
            services.TryAddSingleton<IActionContextAccessor, ActionContextAccessor>();
            services.AddAuthentication().AddGoogle(option =>
            {
                option.ClientId = "802324619902-gu2gaanba2pl6rm822m5d4ggkgm015ke.apps.googleusercontent.com";
                option.ClientSecret = "VNC3K0qeKoFXiwUVtSuouVBL";
            })
            .AddFacebook(Option =>
            {
                Option.AppId = "200721397929469";
                Option.AppSecret = "c51fc8c57033907b8591255a3718e96b";
            }
                );
            services.Configure<SecurityStampValidatorOptions>(options =>
            options.ValidationInterval = TimeSpan.FromSeconds(10));


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
