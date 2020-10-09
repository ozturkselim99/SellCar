using sellcar.data.Abstract;
using sellcar.entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using sellcar.data.Concrete.EfCore;
using sellcar.business.Abstract;
using sellcar.business.Concrete;
using sellcar.webui.Models;
using sellcar.webui.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Localization;
using System.Globalization;
using System.Reflection.Metadata;

namespace SellCar.WebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<ApplicationContext>(options => options.UseSqlite("Data Source=Db"));
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();
            services.Configure<IdentityOptions>(options =>
            {
                // password
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = true;

                // Lockout                
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.AllowedForNewUsers = true;

                // options.User.AllowedUserNameCharacters = "";
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;
            });
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.Cookie = new CookieBuilder
                {
                    HttpOnly = true,
                    Name = ".SellCar.Security.Cookie",
                    SameSite = SameSiteMode.Strict
                };
            });
            services.AddScoped<IIlanRepository, EfCoreIlanRepository>();
            services.AddScoped<IMarkaRepository, EfCoreMarkaRepository>();
            services.AddScoped<IResimRepository, EfCoreResimRepository>();
            services.AddScoped<IFavRepository, EfCoreFavRepository>();
            services.AddScoped<IIlRepository, EfCoreIlRepository>();


            services.AddScoped<IIlanService, IlanManager>();
            services.AddScoped<IMarkaService, MarkaManager>();
            services.AddScoped<IResimService, ResimManager>();
            services.AddScoped<IFavService, FavManager>();
            services.AddScoped<IIlService, IlManager>();
            services.AddControllersWithViews();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IConfiguration configuration, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            var cultureInfo = new CultureInfo("tr-TR");
            cultureInfo.NumberFormat.NumberDecimalSeparator = ".";

            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
            app.UseSession();
            app.UseStaticFiles(); //wwwroot
            if (env.IsDevelopment())
            {
                SeedDatabase.Seed();
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "adminuseredit",
                  pattern: "admin/user/{id?}",
                  defaults: new { controller = "Admin", action = "UserEdit" }
                );
                endpoints.MapControllerRoute(
                  name: "adminuser",
                  pattern: "admin/user/list",
                  defaults: new { controller = "Admin", action = "UserList" }
                );
                endpoints.MapControllerRoute(
                  name: "adminuser",
                  pattern: "admin/user/delete",
                  defaults: new { controller = "Admin", action = "UserDelete" }
                );
                endpoints.MapControllerRoute(
                  name: "adminroles",
                  pattern: "admin/role/list",
                  defaults: new { controller = "Admin", action = "RoleList" }
                );
                endpoints.MapControllerRoute(
                  name: "adminrolecreate",
                  pattern: "admin/role/create",
                  defaults: new { controller = "Admin", action = "RoleCreate" }
                );
                endpoints.MapControllerRoute(
                  name: "adminroleedit",
                  pattern: "admin/role/{id?}",
                  defaults: new { controller = "Admin", action = "RoleEdit" }
                );
                endpoints.MapControllerRoute(
                  name: "adminroleedit",
                  pattern: "admin/role/delete",
                  defaults: new { controller = "Admin", action = "RoleDelete" }
                );
                endpoints.MapControllerRoute(
                  name: "adminmarkalar",
                  pattern: "admin/marka/list",
                  defaults: new { controller = "Admin", action = "MarkaList" }
                );
                endpoints.MapControllerRoute(
                   name: "adminmarkacreate",
                   pattern: "admin/marka/create",
                   defaults: new { controller = "Admin", action = "MarkaCreate" }
                );
                endpoints.MapControllerRoute(
                   name: "adminmarkaedit",
                   pattern: "admin/marka/{id?}",
                   defaults: new { controller = "Admin", action = "MarkaEdit" }
                );
                endpoints.MapControllerRoute(
                   name: "adminmarkadelete",
                   pattern: "admin/marka/delete",
                   defaults: new { controller = "Admin", action = "MarkaDelete" }
                );
                endpoints.MapControllerRoute(
                 name: "adminiller",
                 pattern: "admin/il/list",
                 defaults: new { controller = "Admin", action = "IlList" }
               );
                endpoints.MapControllerRoute(
                   name: "adminilcreate",
                   pattern: "admin/il/create",
                   defaults: new { controller = "Admin", action = "IlCreate" }
                );
                endpoints.MapControllerRoute(
                   name: "adminiledit",
                   pattern: "admin/il/{id?}",
                   defaults: new { controller = "Admin", action = "IlEdit" }
                );
                endpoints.MapControllerRoute(
                   name: "adminildelete",
                   pattern: "admin/il/delete",
                   defaults: new { controller = "Admin", action = "IlDelete" }
                );
                endpoints.MapControllerRoute(
                   name: "adminilanlar",
                   pattern: "admin/ilan/list",
                   defaults: new { controller = "Admin", action = "IlanList" }
                );
                endpoints.MapControllerRoute(
                   name: "adminilanlar",
                   pattern: "admin/ilan/{id?}",
                   defaults: new { controller = "Admin", action = "IlanEdit" }
                );
                endpoints.MapControllerRoute(
                   name: "adminilanlar",
                   pattern: "admin/ilan/delete",
                   defaults: new { controller = "Admin", action = "IlanDelete" }
                );
                endpoints.MapControllerRoute(
                   name: "cart",
                   pattern: "cart",
                   defaults: new { controller = "Cart", action = "Index" }
                );
                endpoints.MapControllerRoute(
                   name: "userilanedit",
                   pattern: "user/ilan/{id?}",
                   defaults: new { controller = "User", action = "IlanEdit" }
                );
                endpoints.MapControllerRoute(
                   name: "userilan",
                   pattern: "user/ilanlarim",
                   defaults: new { controller = "User", action = "Ilan" }
                );
                endpoints.MapControllerRoute(
                   name: "userfavori",
                   pattern: "user/favorilerim",
                   defaults: new { controller = "User", action = "FavIlan" }
                );
                endpoints.MapControllerRoute(
                   name: "adminuser",
                   pattern: "user/ilan/delete",
                   defaults: new { controller = "User", action = "IlanDelete" }
                );
                endpoints.MapControllerRoute(
                   name: "search",
                   pattern: "search",
                   defaults: new { controller = "Home", action = "Search" }
                );
                endpoints.MapControllerRoute(
                   name: "cars",
                   pattern: "cars/{url?}",
                   defaults: new { controller = "Car", action = "List" }
                );
                endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });
            SeedIdentity.Seed(userManager, roleManager, configuration).Wait();
        }
    }
}
