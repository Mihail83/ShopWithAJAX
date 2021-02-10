using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopWithAJAX.Database;
using ShopWithAJAX.Database.EntityModel;
using ShopWithAJAX.BLL.BusinessModel;
using ShopWithAJAX.BLL.Interfaces;
using ShopWithAJAX.BLL.Mapper;
using ShopWithAJAX.BLL.BusinessLogic;
using ShopWithAJAX.WEB.Models;
using ShopWithAJAX.WEB.Mapper;




namespace ShopWithAJAX.WEB
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
            services.AddControllersWithViews();
            services.RegisterDALServices(Configuration);
            services.AddSingleton<IMapper<ShopEntity, Shop>,MapperFromShopEntityToShop >();
            services.AddSingleton<IMapper<Shop,ShopEntity>, MapperFromShopToShopEntity>();
            services.AddSingleton<IMapper<Shop, ShopMinViewModel>, MapperFromShopToShopMinViewModel>();

            services.AddScoped<ShopSupplier>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
