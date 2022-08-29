using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using DAL;
using DAL.Models;
using DTO;
using BLL;
using Microsoft.EntityFrameworkCore;

namespace WebApi
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
            services.AddControllers();
            services.AddCors(p => p.AddPolicy("AlowAll", option =>
            {
                option.AllowAnyMethod();
                option.AllowAnyHeader();
                option.AllowAnyOrigin();
            }));
            services.AddScoped(typeof(IUsersDal), typeof(UsersDal));
            services.AddScoped(typeof(IUsersBLL), typeof(UserBLL));

            services.AddScoped(typeof(IPurchaseDAL), typeof(PurchaseDAL));
            services.AddScoped(typeof(IPurchaseBLL), typeof(PurchaseBLL));

            services.AddScoped(typeof(IProductDAL), typeof(ProductDAL));
            services.AddScoped(typeof(IProductBLL), typeof(ProductBLL));

            services.AddScoped(typeof(ICategoryDAL), typeof(CategoryDAL));
            services.AddScoped(typeof(ICategoryBLL), typeof(CategoryBLL));

            services.AddScoped(typeof(IPurchaseDitailDAL), typeof(PurchaseDitailDAL));
            services.AddScoped(typeof(IPurchaseDitailBLL), typeof(PurchaseDitailBLL));
           
            services.AddDbContext<FurnitursContext>(option =>
            option.UseSqlServer("Server=prog17\\sql;Database=Furniturs;Trusted_Connection=true"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors("AlowAll");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
