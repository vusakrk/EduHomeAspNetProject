using EduHomeAspNetProject.DAL;
using EduHomeAspNetProject.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject
{
    public class Startup
    {
        public IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddIdentity<AppUser, IdentityRole>(IdentityOptions =>
            {
                IdentityOptions.Password.RequireDigit = true;
                IdentityOptions.Password.RequireLowercase = true;
                IdentityOptions.Password.RequireUppercase = true;
                IdentityOptions.Password.RequiredLength = 7;
                IdentityOptions.Password.RequireNonAlphanumeric = false;

                IdentityOptions.User.RequireUniqueEmail = true;

                IdentityOptions.Lockout.MaxFailedAccessAttempts = 5;
                IdentityOptions.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(3);
                IdentityOptions.Lockout.AllowedForNewUsers = true;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
            services.AddControllersWithViews();
            services.AddNewsletterService();
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(_config.GetConnectionString("Default"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            //app.UseSession();
            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "areas",
                   pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
          );
                endpoints.MapControllerRoute(
                    "default",
                    "{controller=Home}/{action=Index}/{Id?}"
                    );
            });
        }
    }
}
