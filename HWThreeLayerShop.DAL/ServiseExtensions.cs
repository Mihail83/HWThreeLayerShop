using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using HWThreeLayerShop.DAL.EF;
using HWThreeLayerShop.DAL.Repositories;
using HWThreeLayerShop.BLL.Interfaces;

namespace HWThreeLayerShop.DAL
{
    public static class ServiseExtensions
    {
        public static IServiceCollection RegisterDALServices(this IServiceCollection services, IConfiguration configeration)
        {
            services.AddDbContext<ShopContext>(option => option.UseSqlServer(configeration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IRepository, ShopContextRepository>();
            return services;
        }        
    }
}
