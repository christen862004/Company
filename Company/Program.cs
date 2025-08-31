using Company.Models;
using Company.Reposiotry;
using Microsoft.EntityFrameworkCore;

namespace Company
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.//Sessikon8
            //framowrik service
            //1) service define and already register
            //2) services defianed but need to regster <---
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<CompanyContext>(optionBuilder => {
                optionBuilder.UseSqlServer(builder.Configuration.GetConnectionString("cs"));
            });//register Option ,CompanyContext

            //3) Cusotm service

            //register serice in Container
            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddScoped<IDeptartmentRepository, DepartmentRepository>();
           // builder.Services.AddScoped<IFakeRepo, FakeRepo>();

            var app = builder.Build();

            // Configure the HTTP request pipeline. middleware Day3
            #region Custom Middlew (inline Middleware)

            //app.Use(async (httpContext, NextMiddleware) =>
            //{
            //    await httpContext.Response.WriteAsync("1- Middleware 1 \n");
            //    await NextMiddleware.Invoke();
            //    await httpContext.Response.WriteAsync("1-1 Middleware 1-1 \n");

            //});//execute ,call next
            //app.Use(async (httpContext, NextMiddleware) =>
            //{
            //    await httpContext.Response.WriteAsync("2- Middleware 2 \n");
            //    await NextMiddleware.Invoke();
            //    await httpContext.Response.WriteAsync("2-2 Middleware 2-2 \n");

            //});//execute ,call next
            //app.Run(async (httpcontext) => {
            //    //if
            //  await   httpcontext.Response.WriteAsync("3- Terminate\n");
            //});

            #endregion

            #region Built in Middleware
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles(); //understant static filed that found in wwwroot

            app.UseRouting();//mapping

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            #endregion

            app.Run();
        }
    }
}
