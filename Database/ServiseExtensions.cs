using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using ShopWithAJAX.Database.EF;
using ShopWithAJAX.Database.EntityModel;
using ShopWithAJAX.Database.Interfaces;
using ShopWithAJAX.Database.Repository;

namespace ShopWithAJAX.Database
{
    public static class ServiseExtensions
    {
        public static IServiceCollection RegisterDALServices(this IServiceCollection services, IConfiguration configeration)
        {
            services.AddDbContext<ShopContext>(option => option.UseSqlServer(configeration.GetConnectionString("defaultconnection")));            
            services.AddScoped<IShopRepository, ShopRepository>();
            return services;
        }        
    }
}
